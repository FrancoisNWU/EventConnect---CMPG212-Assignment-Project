//Premium user-Dashboard form
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
    public partial class Premiumfrm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet dataSet;
        SqlDataReader reader;

        
        public int ID_ { get; set; }
        public string update_string = "";
        public Premiumfrm()
        {
            InitializeComponent();
        }

        //Method Reset input to origanal/empty state
        public void ResetInput()
        {
            pnlInput.Visible = true;
            lblName.Text = "Event Name: ";
            lblVenue.Text = "Venue: ";
            lblMax.Text = "Max capacity: ";

            lblName.Visible = false;
            lblVenue.Visible = false;
            cbRegistration.Visible = false;
            lblDate.Visible = false;
            lblTime.Visible = false;
            lblCapacity.Visible = false;
            lblMax.Visible = false;
            
            lblDescription.Visible = false;
            lblAttendees.Visible = false;
            lblPrice.Visible = false;

            txtPrice.Visible = false;
            txtAttendees.Visible = false;
            txtDate.Visible = false;
            lblDateFormat.Visible = false;
            txtCapacity.Visible = false; 
            txtDescription.Visible = false;
            txtName.Visible = false;

            cmbTime.Visible = false;
            cmbVenues.Visible = false;
            cmbNames.Items.Clear();

            cmbNames.Visible = false;
            lblnewName.Visible = false;

            lblHeader.Text = "List of upcoming events";

            txtDate.Text = "";
            txtCapacity.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cbRegistration.Checked = false;
            cmbTime.SelectedIndex = -1;
            cmbVenues.SelectedIndex = -1;

            cmbVenues.Items.Clear();
            cmbVenues.Items.Add("Crystal Gardens Convention Center");
            cmbVenues.Items.Add("Starlight Ballroom");
            cmbVenues.Items.Add("Serenity Plaza");
            cmbVenues.Items.Add("Golden Pavilion ");
            cmbVenues.Items.Add("Emerald Hall");
            cmbVenues.Items.Add("Moonbeam Theater");
            cmbVenues.Items.Add("Harmony Lounge");

            cmbColumn.Visible = false;
            lblColumn.Visible = false;

            btnConfirm.Visible = false;
            btnadd.Visible = false;
            btnDeleteData.Visible = false;
        }

        //Method check if registered checkbox is clicked and return result
        public string checkRegistration()
        {
            string register = "";
            if(cbRegistration.Checked)
            {
                register = "Available";
            }
            else
            {
                register = "Unavailable";
            }
            return register;
        }

        //Update database with user's events
        public void UpdateDG()
        {
            try
            {
                conn.Open();
                command = new SqlCommand(@"SELECT * FROM EventsTable WHERE Host_ID = " + ID_ + " ", conn);
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout back to first page
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResetInput();
            btnShowAll.Text = "Show all events";
            //Make relevant controlls visible
            pnlInput.Visible = true;
            lblColumn.Visible = true;
            cmbColumn.Visible = true;
            btnConfirm.Visible = true;
            lblName.Visible = true;
            txtName.Visible = true;
            cmbColumn.SelectedIndex = -1;


            //Show events the current user is going to host
            lblUserEvent.Text = "List of your events";

            //Fill datagrid with user's events
            try
            {
                conn.Open();
                command = new SqlCommand(@"SELECT * FROM EventsTable WHERE Host_ID = " + ID_ + " ", conn);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(txtName.Text!="")
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
                if(find==true)
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(update_string, conn);


                        //Fill command paramaters according to selected column
                        switch (cmbColumn.SelectedIndex)
                        {
                            case 0:
                                command.Parameters.AddWithValue("@Name", cmbNames.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Input", txtName.Text);
                                break;
                            case 1:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", cmbVenues.SelectedItem.ToString());
                                break;
                            case 2:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", checkRegistration());
                                break;
                            case 3:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", txtDate.Text);
                                break;
                            case 4:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", cmbTime.SelectedItem.ToString());
                                break;
                            case 5:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", int.Parse(txtCapacity.Text));
                                break;
                            case 6:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", txtDescription.Text);
                                break;
                            case 7:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", int.Parse(txtAttendees.Text));
                                break;
                            case 8:
                                command.Parameters.AddWithValue("@Name", txtName.Text);
                                command.Parameters.AddWithValue("@Input", decimal.Parse(txtPrice.Text));
                                break;
                            default:
                                break;
                        }

                        command.ExecuteNonQuery();

                        btnConfirm.Visible = false;


                        conn.Close();

                        MessageBox.Show("Event updated sucessfully");

                        //Reset input controls
                        ResetInput();
                        //Update dataGrid
                        UpdateDG();
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
                errorProvider.SetError(txtName, "Enter name of event you want to edit");
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Make relevant controls visible
            ResetInput();

            lblName.Visible = true;
            lblVenue.Visible = true;
            cbRegistration.Visible = true;
            lblDate.Visible = true;
            lblTime.Visible = true;
            lblCapacity.Visible = true;
            lblMax.Visible = true;
            
            lblDescription.Visible = true;
            lblAttendees.Visible = true;
            lblPrice.Visible = true;

            txtPrice.Visible = true;
            txtAttendees.Visible = true;
            txtDate.Visible = true;
            lblDateFormat.Visible = true;
            txtCapacity.Visible = true;
            txtDescription.Visible = true;
            txtName.Visible = true;
            cmbTime.Visible = true;
            cmbVenues.Visible = true;


            //Show events the current user is going to host
            lblUserEvent.Text = "List of your events";
            pnlInput.Visible = true;
            btnadd.Visible = true;

            //Update dataGrid
            UpdateDG();

        }

        private void Premiumfrm_Load(object sender, EventArgs e)
        {
            //Populate event comboBox
            cmbVenues.Items.Clear();
            cmbVenues.Items.Add("Crystal Gardens Convention Center");
            cmbVenues.Items.Add("Starlight Ballroom");
            cmbVenues.Items.Add("Serenity Plaza");
            cmbVenues.Items.Add("Golden Pavilion ");
            cmbVenues.Items.Add("Emerald Hall");
            cmbVenues.Items.Add("Moonbeam Theater");
            cmbVenues.Items.Add("Harmony Lounge");

            //Add user ID to header
            lblHeader.Text = "Premium DashBoard for: " + ID_.ToString();


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
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
               
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Change relevant input controls
            ResetInput();
            btnShowAll.Text = "Show all events";
            pnlInput.Visible = true;
            lblName.Visible = true;
            txtName.Visible = true;
            btnDeleteData.Visible = true;

            //Update dataGrid
            UpdateDG();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //Show all events or Host's events 

            if(btnShowAll.Text=="Show all events")
            {
                btnShowAll.Text = "Show my events";

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
            else
            {
                btnShowAll.Text = "Show all events";
                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT * FROM EventsTable WHERE Host_ID="+ID_+"", conn);
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

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //Delete data from database
            try
            {
                //Look for name in database
                conn.Open();
                command = new SqlCommand(@"SELECT Name FROM EventsTable", conn);
                reader = command.ExecuteReader();
                bool find = false;

                
                while(reader.Read())
                {
                    if(txtName.Text == reader.GetValue(0).ToString())
                    {
                        find = true;
                    }
                }
                reader.Close();

                //If name is found: Delete its record
                //If name not found: Let user know
                if (find ==true)
                {
                    SqlCommand delete_com = new SqlCommand("DELETE FROM EventsTable WHERE Name='" + txtName.Text + "'",conn);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = delete_com;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    ResetInput();
                    MessageBox.Show("Record deleted sucessfully");
                }
                else
                {
                    errorProvider.SetError(txtName, "Could not find name in Database");
                }

                conn.Close();
                UpdateDG();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //Input validation using errorProvider, before adding event
            if (txtName.Text != "")
            {
                if (cmbVenues.SelectedIndex != -1)
                {
                    if (txtDate.Text != "")
                    {
                        if (cmbTime.SelectedIndex != -1)
                        {
                            if (txtCapacity.Text != "")
                            {
                                if (txtDescription.Text != "")
                                {
                                    //Save venue's max capacity in variable
                                    int Max_capacity = 0;
                                    switch (cmbVenues.SelectedIndex)
                                    {
                                        case 0:
                                            Max_capacity = 1000;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 1:
                                            Max_capacity = 500;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 2:
                                            Max_capacity = 300;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 3:
                                            Max_capacity = 250;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 4:
                                            Max_capacity = 200;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 5:
                                            Max_capacity = 150;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        case 6:
                                            Max_capacity = 100;
                                            lblMax.Text = "Max capacity: " + Max_capacity;
                                            break;
                                        default:
                                            break;
                                    }

                                    if(!(int.Parse(txtCapacity.Text)>Max_capacity))
                                    {
                                        //Add event to database
                                        try
                                        {
                                            conn.Open();

                                            command = new SqlCommand($"INSERT INTO EventsTable VALUES ('{ID_}','{txtName.Text}', '{cmbVenues.SelectedItem.ToString()}', '{checkRegistration()}','{txtDate.Text}','{cmbTime.SelectedItem.ToString()}','{txtCapacity.Text}','{txtDescription.Text}','{int.Parse(txtAttendees.Text)}','{Convert.ToDecimal(txtPrice.Text)}' )", conn);
                                            adapter = new SqlDataAdapter();
                                            adapter.InsertCommand = command;
                                            adapter.InsertCommand.ExecuteNonQuery();

                                            MessageBox.Show("Event Created!");


                                            conn.Close();
                                            //reset input
                                            ResetInput();
                                            UpdateDG();
                                        }
                                        catch (SqlException ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        errorProvider.SetError(txtCapacity, "Please enter smaller capacity then Max");
                                    }

                                }
                                else
                                {
                                    errorProvider.SetError(txtDescription, "Please enter description of event");
                                }
                            }
                            else
                            {
                                errorProvider.SetError(txtCapacity, "Please enter total capacity");
                            }
                        }
                        else
                        {
                            errorProvider.SetError(cmbTime, "Please select event start time");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtDate, "Please enter event date");
                    }
                }
                else
                {
                    errorProvider.SetError(cmbVenues, "Please select venue");
                }
            }
            else
            {
                errorProvider.SetError(txtName, "Please enter event name");
            }
            UpdateDG();
        }

        private void cmbVenues_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Save venue's max capacity in label
            int Max_capacity = 0;
            switch (cmbVenues.SelectedIndex)
            {
                case 0:
                    Max_capacity = 1000;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 1:
                    Max_capacity = 500;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 2:
                    Max_capacity = 300;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 3:
                    Max_capacity = 250;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 4:
                    Max_capacity = 200;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 5:
                    Max_capacity = 150;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                case 6:
                    Max_capacity = 100;
                    lblMax.Text = "Max capacity: " + Max_capacity;
                    break;
                default:
                    break;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ResetInput();
            //Open profile edit form
            Profilefrm profile = new Profilefrm();
            this.Hide();
            profile.ID_ = ID_;
            profile.ShowDialog();
            this.Close();
        }

        private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Make controlls visible according to user input
            switch (cmbColumn.SelectedIndex)
            {
                case 0:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = false;
                    cmbColumn.Visible = false;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    cmbNames.Visible = true;
                    lblnewName.Visible = true;
                    lblName.Text = "New Name: ";

                    //Fill name comboBox with current names
                    try
                    {
                        conn.Open();

                        command = new SqlCommand(@"SELECT Name FROM EventsTable WHERE Host_ID=" + ID_ + "", conn);
                        reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            cmbNames.Items.Add(reader.GetValue(0).ToString());
                        }
                        reader.Close();
                        conn.Close();
                    }
                    catch(SqlException x)
                    {
                        MessageBox.Show(x.Message);
                    }

                    update_string = @"UPDATE EventsTable SET Name = @Input WHERE Name = @Name ";
                    break;
                case 1:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblVenue.Visible = true;
                    cmbVenues.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Venue = @Input WHERE Name = @Name ";
                    break;
                case 2:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    cbRegistration.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Registration = @Input WHERE Name = @Name ";
                    break;
                case 3:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblDate.Visible = true;
                    txtDate.Visible = true;
                    lblDateFormat.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Date = @Input WHERE Name = @Name ";
                    break;
                case 4:
                    
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblTime.Visible = true;
                    cmbTime.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Time = @Input WHERE Name = @Name ";
                    break;
                case 5:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblCapacity.Visible = true;
                    lblMax.Visible = true;
                    
                    txtCapacity.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Capacity = @Input WHERE Name = @Name ";
                    break;
                case 6:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblDescription.Visible = true;
                    txtDescription.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Description = @Input WHERE Name = @Name ";
                    break;
                case 7:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblAttendees.Visible = true;
                    txtAttendees.Visible = true;
                    update_string = @"UPDATE EventsTable SET  Guests_nr = @Input WHERE Name = @Name ";
                    break;
                case 8:
                    ResetInput();
                    pnlInput.Visible = true;
                    lblColumn.Visible = true;
                    cmbColumn.Visible = true;
                    btnConfirm.Visible = true;
                    lblName.Visible = true;
                    txtName.Visible = true;
                    lblPrice.Visible = true;
                    txtPrice.Visible = true;
                    update_string = @"UPDATE EventsTable SET Entrance_Price = @Input WHERE Name = @Name ";
                    break;
                default:
                    break;
            }
        }

        //Change button colour when hovering over it
        private void btnNew_MouseEnter(object sender, EventArgs e)
        {
            btnNew.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            btnNew.BackColor = Color.LightCyan;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.LightCyan;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightCyan;
        }

        private void btnEditProfile_MouseEnter(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnEditProfile_MouseLeave(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.LightCyan;
        }
    }
}
