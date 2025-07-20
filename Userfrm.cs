// Normal user-Dashboard form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _40723380_Verster_CMPG212_Exam
{

    public partial class Userfrm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet dataSet;
        SqlDataReader reader;

        public int ID_ { get; set; }
        public decimal currentEventTotal = 0;
        public Userfrm()
        {
            InitializeComponent();
        }

        //Method reset input controls
        public void resetInput()
        {
            gbInput.Text = "Input";

            lblDate.Visible = false;
            lblHostID.Visible = false;
            lblName.Visible = false;
            lbltickets.Visible = false;
            lblVenue.Visible = false;

            cmbVenues.Visible = false;
            cmbHost.Visible = false;
            txtName.Visible = false;
            txtTickets.Visible = false;
            cbRegister.Visible = false;

            txtDate.Visible = false;

            btnBook.Visible = false;

            //Populate event comboBox
            cmbVenues.Items.Clear();
            cmbVenues.Items.Add("Crystal Gardens Convention Center");
            cmbVenues.Items.Add("Starlight Ballroom");
            cmbVenues.Items.Add("Serenity Plaza");
            cmbVenues.Items.Add("Golden Pavilion ");
            cmbVenues.Items.Add("Emerald Hall");
            cmbVenues.Items.Add("Moonbeam Theater");
            cmbVenues.Items.Add("Harmony Lounge");

            errorProvider.Clear();

            txtDate.Text = "";
            txtName.Text = "";
            txtTickets.Text ="";
            cmbHost.SelectedIndex = -1;
            cmbVenues.SelectedIndex = -1;
        }

        //method that fills datagridview
        public void fillDG()
        {
            //Fill datagrid with all events
            try
            {
                conn.Open();
                command = new SqlCommand(@"SELECT * FROM EventsTable", conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "EventsTable");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "EventsTable";

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Userfrm_Load(object sender, EventArgs e)
        {
            resetInput();
            fillDG();
            lblHeader.Text = "User DashBoard: " + ID_;
            //Fill Host-ID comboBox with all Host ID's
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT DISTINCT Host_ID FROM EventsTable", conn);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    cmbHost.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();

                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Set-up relevant controls for registrations
            gbInput.Text = "Register event";
            resetInput();


            lblHostID.Visible = true;
            lblName.Visible = true;
            lbltickets.Visible = true;

            cmbHost.Visible = true;


            txtName.Visible = true;
            txtTickets.Visible = true;


            btnBook.Visible = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout back to first page
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //Input validation using errorProvider
            if (cmbHost.SelectedIndex != -1)
            {
                if (txtName.Text != "")
                {

                    //Look for name in database
                    conn.Open();
                    SqlCommand SearcCommand = new SqlCommand(@"SELECT Name FROM EventsTable", conn);
                    SqlDataReader SearchReader = SearcCommand.ExecuteReader();
                    bool find = false;


                    while (SearchReader.Read())
                    {
                        if (txtName.Text == SearchReader.GetValue(0).ToString())
                        {
                            find = true;
                        }
                    }
                    SearchReader.Close();
                    conn.Close();

                    //Update database if name is found
                    if (find == true)
                    {
                        try
                        {
                            conn.Open();


                            int id = int.Parse(cmbHost.SelectedItem.ToString());
                            int num_guests = 0;
                            string register = "";
                            int max = 0;

                            //Check if: Event registration is open;
                            //Calculate new number of guests;
                            //Check if: Max capacity is not reached;
                            //Add data to relevent fields

                            SqlCommand RegisterCommand = new SqlCommand(@"SELECT Registration FROM EventsTable WHERE Host_ID= " + id + " AND Name='" + txtName.Text + "' ", conn);
                            SqlCommand Guestcommand = new SqlCommand(@"SELECT Guests_nr FROM EventsTable WHERE Host_ID= " + id + " AND Name='" + txtName.Text + "' ", conn);
                            SqlCommand CapcityCommand = new SqlCommand(@"SELECT Capacity FROM EventsTable WHERE Host_ID= " + id + " AND Name='" + txtName.Text + "' ", conn);
                            SqlCommand GetEventPrice = new SqlCommand(@"SELECT Entrance_Price FROM EventsTable WHERE Host_ID= " + id + " AND Name='" + txtName.Text + "'", conn);


                            //Check registration
                            SqlDataReader RegisterReader = RegisterCommand.ExecuteReader();
                            while (RegisterReader.Read())
                            {
                                register = RegisterReader.GetValue(0).ToString();
                            }
                            RegisterReader.Close();



                            if (register == "Available")
                            {
                                //Calculate new total guests
                                SqlDataReader Guestreader = Guestcommand.ExecuteReader();
                                while (Guestreader.Read())
                                {
                                    num_guests = int.Parse(Guestreader.GetValue(0).ToString()) + int.Parse(txtTickets.Text);
                                }
                                Guestreader.Close();


                                //check if total exceeds maximum
                                SqlDataReader CapacityReader = CapcityCommand.ExecuteReader();
                                while (CapacityReader.Read())
                                {

                                    max = int.Parse(CapacityReader.GetValue(0).ToString());
                                }
                                CapacityReader.Close();



                                if (!(num_guests > max))
                                {
                                    //Add new totals to relevant columns


                                    //Update total guests in event table
                                    SqlCommand AddEventCommand = new SqlCommand(@"UPDATE EventsTable SET  Guests_nr = " + num_guests + " WHERE Name = @Name AND Host_ID = @ID ", conn);
                                    AddEventCommand.Parameters.AddWithValue("@Name", txtName.Text);
                                    AddEventCommand.Parameters.AddWithValue("@ID", int.Parse(cmbHost.SelectedItem.ToString()));
                                    AddEventCommand.ExecuteNonQuery();


                                    //Update user's total expenses in user table
                                    SqlDataReader EventPriceReader = GetEventPrice.ExecuteReader();
                                    while (EventPriceReader.Read())
                                    {
                                        currentEventTotal = Convert.ToInt32(decimal.Parse(EventPriceReader.GetValue(0).ToString()) * (decimal.Parse(txtTickets.Text)));
                                    }
                                    EventPriceReader.Close();


                                    SqlCommand addUserPriceCommand = new SqlCommand(@"UPDATE UserTable SET Total_Expenses = Total_Expenses+ " + currentEventTotal + "  WHERE User_ID = @ID ", conn);
                                    addUserPriceCommand.Parameters.AddWithValue("@ID", ID_);
                                    addUserPriceCommand.ExecuteNonQuery();
                                    MessageBox.Show("You sucessfully registered", "Congratulations", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Unable to book event: Tickets exceed event capacity");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Unable to book event: Registration Closed");
                            }

                            conn.Close();

                            //reset input and refresh datagrid
                            resetInput();
                            fillDG();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtName, "Couldn't find event with that name");
                    }
                }
                else
                {
                    errorProvider.SetError(txtName, "Enter event name");
                }
            }
            else
            {
               errorProvider.SetError(cmbHost, "Select Host ID");
            }

                  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            resetInput();
            lblHostID.Visible = true;
            lblName.Visible = true;
            lblVenue.Visible = true;
            lblDate.Visible = true;

            txtName.Visible = true;
            txtDate.Visible = true;
            cmbVenues.Visible = true;
            cmbHost.Visible = true;
            cbRegister.Visible = true;
        }

        private void cmbHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Filter data according to host IDs
            if(cmbHost.SelectedIndex!=-1)
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand("SELECT * FROM EventsTable WHERE Host_ID = '" + int.Parse(cmbHost.SelectedItem.ToString()) + "' ", conn);
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "EventsTable");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "EventsTable";
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Filter data according to name typed in
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT * FROM EventsTable WHERE Name LIKE '%" + txtName.Text + "%'", conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "EventsTable");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "EventsTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            //Filter data according to Date typed in
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT * FROM EventsTable WHERE Name LIKE '%" + txtDate.Text + "%'", conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "EventsTable");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "EventsTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbVenues_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Filter data according to selected venue
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT * FROM EventsTable WHERE Venue= '" + cmbVenues.SelectedItem.ToString() + "'", conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "EventsTable");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "EventsTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRegister_CheckedChanged(object sender, EventArgs e)
        {
            string S_command = "";
            if(cbRegister.Checked)
            {
                S_command = "SELECT * FROM EventsTable WHERE Registration = 'Available'";
            }
            else
            {
                S_command = "SELECT * FROM EventsTable WHERE Registration = 'Unavailable'";
            }

            //Filter data according to selected venue
            try
            {
                conn.Open();
                command = new SqlCommand(S_command, conn);
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "EventsTable");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "EventsTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Fill datagrid with user's data
            if (btnShow.Text== "Show personal data")
            {
                btnShow.Text = "Show Events";
                
                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT * FROM UserTable WHERE User_ID=" + ID_ + " ", conn);
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "UserTable");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "UserTable";

                    conn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {

                //Fill datagrid with event data
                btnShow.Text = "Show personal data";

                
                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT * FROM EventsTable", conn);
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "EventsTable");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "EventsTable";

                    conn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }



        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

            //Open profile edit form
            Profilefrm profile = new Profilefrm();
            this.Hide();
            profile.ID_ = ID_;
            profile.ShowDialog();
            this.Close();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            decimal prev_total = 0;

            //Check if user made a new event before financial request
            //If new event, a more detailed report is given
            if (currentEventTotal>0)
            {

                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT Total_Expenses FROM UserTable WHERE User_ID="+ID_+"", conn);
                    reader = command.ExecuteReader();

                    
                    while(reader.Read())
                    {
                        prev_total = decimal.Parse(reader.GetValue(0).ToString()) - currentEventTotal;
                    }

                    conn.Close();
                    MessageBox.Show("Total before previous registration: " + prev_total.ToString("C") + "\n\nNew event total: " + currentEventTotal.ToString("C") + "\n\nGrand Total: " +
                    (prev_total + currentEventTotal).ToString("C"), "Financial Report", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }
            else
            {
                //If not, an overall total is given
                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT Total_Expenses FROM UserTable WHERE User_ID=" + ID_ + "", conn);
                    reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        prev_total = decimal.Parse(reader.GetValue(0).ToString());
                    }

                    conn.Close();
                    MessageBox.Show("Grand Total of all expences: " +prev_total.ToString("C"), "Financial Report", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        //Change button colour when hovering over it
        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.MintCream;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.MintCream;
        }

        private void btnFinance_MouseEnter(object sender, EventArgs e)
        {
            btnFinance.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnFinance_MouseLeave(object sender, EventArgs e)
        {
            btnFinance.BackColor = Color.MintCream;
        }

        private void btnEditProfile_MouseEnter(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnEditProfile_MouseLeave(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.MintCream;
        }
    }
}
