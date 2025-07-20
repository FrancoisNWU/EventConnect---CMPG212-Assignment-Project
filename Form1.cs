/* Francois Verster 40723380 - Exam-June :  cmpg 212 - Project
 * 
 * Login Details for marker:
 * 
 * Premium account:
 * -ID = 1234
 * -Password: Bobby
 * 
 * Normal user account:
 * -ID: 4321
 * -Password: Snowy
 * 
 */


// Login + Create account Form
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
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader dataReader;

       
        public string user_action = "";
        public string premium = "False";
        public frmLogin()
        {
            InitializeComponent();
        }

        //Method that clears input
        public void ClearInput()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            cbPremium.Checked = false;
            lblName.Text = "Name: ";
            pnlInput.Visible = false;

            lblSurname.Visible = true;
            txtSurname.Visible = true;
            errorProvider.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Clear Input
            ClearInput();
            lblName.Text = "ID: ";

            //Make panel visible 
            pnlInput.Visible = true;

            lblSurname.Visible = false;
            txtSurname.Visible = false;
            cbPremium.Visible = false;
            InformationIcon.Visible = false;
            user_action = "Login";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            //Clear Input
            ClearInput();

            //Make panel aswell as comboBox + Icon for premium visible
            pnlInput.Visible = true;
            cbPremium.Visible = true;
            InformationIcon.Visible = true;
            user_action = "Create";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool User_find = false;


            //Check if user want to login or create account
            //If user want to login, check if user ID + Password exists and match
            if(user_action=="Login")
            {
                try
                {
                    conn.Open();

                    command = new SqlCommand($"SELECT * FROM UserTable", conn);
                    dataReader = command.ExecuteReader();

                    //Check if input ID exists
                    while(dataReader.Read())
                    {

                        if (dataReader.GetValue(0).ToString() == txtName.Text)
                        {
                            User_find = true;
                            break;
                        }
                    }
                    dataReader.Close();


                    //Check if password matches ID
                    if(User_find==true)
                    {
                        command = new SqlCommand($"SELECT * FROM UserTable WHERE User_ID = '"+txtName.Text+"'  ", conn);
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            if (dataReader.GetValue(3).ToString() == txtPassword.Text)
                            {

                                string prem = dataReader.GetValue(4).ToString();

                                dataReader.Close();
                                conn.Close();

                                int ID = int.Parse(txtName.Text);
                                //Open new page according to Premium
                                if (prem=="True")
                                {
                                    this.Hide();
                                    Premiumfrm Prem = new Premiumfrm();
                                    Prem.ID_ = ID;
                                    Prem.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    this.Hide();
                                    Userfrm user = new Userfrm();
                                    user.ID_ = ID;
                                    user.ShowDialog();
                                    this.Close();
                                }

                                //Clear input and make panel invisible
                                ClearInput();
                                pnlInput.Visible = false;
                                cbPremium.Visible = false;
                                InformationIcon.Visible = false;

                                break;
                            }
                            else
                            {
                                errorProvider.SetError(txtPassword, "Incorrect password");//Error message for wrong password
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Could not find user ID, please try again");
                    }

                    conn.Close();

                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

            //Determine if user want to create account
            if(user_action=="Create")
            {

                //Check input validation before adding user
                if (txtName.Text != "")
                {
                    if (txtSurname.Text != "")
                    {
                        if (txtPassword.Text != "")
                        {

                            //Generate 4 digit unique user ID
                            int ID=0;
                            conn.Open();
                            command = new SqlCommand($"SELECT User_ID from UserTable", conn);
                            dataReader = command.ExecuteReader();

                            bool unique = false;
                            while (!unique)
                            {
                                Random rand = new Random();
                                ID = rand.Next(1000, 10000);

                                while(dataReader.Read())
                                {
                                    if(ID.ToString()== dataReader.GetValue(0).ToString())
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        unique = true;
                                    }
                                    
                                }
                            }

                            conn.Close();


                            //Add new user to Database
                            try
                            {
                               conn.Open();

                               command = new SqlCommand($"INSERT INTO UserTable VALUES ('{ID}','{txtName.Text}', '{txtSurname.Text}', '{txtPassword.Text}','{premium}','{0}' )", conn);
                               adapter = new SqlDataAdapter();
                               adapter.InsertCommand = command;
                               adapter.InsertCommand.ExecuteNonQuery();

                               MessageBox.Show("Account created!\nYour ID is: "+ ID,"Account creation",MessageBoxButtons.OK);
                               ClearInput();

                               conn.Close();


                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else
                        {
                            errorProvider.SetError(txtPassword, "Please enter your password"); //Error message regarding password
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtSurname, "Please enter your surname");//Error message regarding surname
                    }
                }
                else
                {
                    errorProvider.SetError(txtName, "Please enter you name");//Error message regarding name
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit program
        }

        private void cbPremium_CheckedChanged(object sender, EventArgs e)
        {
            //change premium variable
            if(premium=="False")
            {
                premium = "True";
            }
            else
            {
                premium = "False";
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //Change button colour when hovering over it
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightYellow;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ButtonFace;
        }

        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.LightYellow;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = SystemColors.ButtonFace;
        }
    }
}
