//Edit profile form
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
    public partial class Profilefrm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public int ID_ { get; set; }
        public Profilefrm()
        {
            InitializeComponent();
        }

        //Reset input controls to default/empty state
        public void resetInput()
        {

            lblInput.Visible = false;
            lblColumn.Visible = false;
            cmbDetail.Visible = false;
            btnConfirm.Visible = false;
            btnUpdate.Visible = false;
            txtInput.Visible = false;
            txtInput.Text = "";
            txtOldPassword.Text = "";
            txtOldPassword.Visible = false;
            lblOldPassword.Visible = false;
            errorProvider.Clear();


        }
        //Method update listbox with user Information
        public void updateLst()
        {
            lstOutput.Items.Clear();
           try
            {
                string bluredPassword = "";
                conn.Open();

                command = new SqlCommand(@"SELECT * FROM UserTable WHERE User_ID=" + ID_ + "", conn);
                reader = command.ExecuteReader();

                lstOutput.Items.Add("-------------User Information--------------");
                lstOutput.Items.Add(" ");
                while (reader.Read())
                {
                    lstOutput.Items.Add("User ID: " + reader.GetValue(0).ToString());
                    lstOutput.Items.Add(" ");
                    lstOutput.Items.Add("Name: " + reader.GetValue(1).ToString());
                    lstOutput.Items.Add(" ");
                    lstOutput.Items.Add("Surname: " + reader.GetValue(2).ToString());
                    lstOutput.Items.Add(" ");

                    //Blur every letter (except 1st) of password
                    for(int i=1;i< reader.GetValue(3).ToString().Length;i++)
                    {
                        bluredPassword += "*";
                    }
                    lstOutput.Items.Add("Password: " + reader.GetValue(3).ToString().Substring(0,1)+bluredPassword);


                    lstOutput.Items.Add(" ");
                    lstOutput.Items.Add("Premium: " + reader.GetValue(4).ToString());
                    lstOutput.Items.Add(" ");
                    lstOutput.Items.Add("Total Expense: " + reader.GetValue(5).ToString());

                    if(reader.GetValue(4).ToString()=="True")
                    {
                        //Strikeout premium button's text if user is already premium
                        btnPremium.Font = new Font(btnPremium.Font, FontStyle.Strikeout);
                        btnPremium.Enabled = false;
                        
                    }
                    else
                    {
                        btnPremium.Enabled = true;
                    }
                }
                reader.Close();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Profilefrm_Load(object sender, EventArgs e)
        {
            updateLst();
            resetInput();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout back to first page
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            cbPremium.Visible = true;
        }

        private void cbPremium_CheckedChanged(object sender, EventArgs e)
        {

            //Ask if user sure to change to premium
            //If user confirms, change account to premium
            DialogResult Des = MessageBox.Show("Are you sure you want to change account to Premium?", "Change to Premium",MessageBoxButtons.YesNo);

            if(Des==DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    command = new SqlCommand(@"UPDATE UserTable SET  Premium = 'True' WHERE User_ID = "+ID_+" ", conn);
                    command.ExecuteNonQuery();

                    conn.Close();
                    cbPremium.Visible = false;
                    btnPremium.Enabled = false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            updateLst();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make controls visible according to comboBox selection
            lblInput.Visible = true;
            txtInput.Visible = true;
            if (cmbDetail.SelectedIndex==0)
            {
                lblInput.Text = "Name: ";
            }
            else
            {
                lblInput.Text = "Surname: ";
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //Input validation
            if(txtInput.Text!="")
            {
                //Update User name or surname according to comboBox selection
                try
                {
                    conn.Open();

                    if (cmbDetail.SelectedIndex == 0)
                    {
                        command = new SqlCommand(@"UPDATE UserTable SET Name='" + txtInput.Text + "' WHERE User_ID = " + ID_ + " ", conn);
                        command.ExecuteNonQuery();
                    }

                    if (cmbDetail.SelectedIndex == 1)
                    {
                        command = new SqlCommand(@"UPDATE UserTable SET Surname ='" + txtInput.Text + "' WHERE User_ID = " + ID_ + " ", conn);
                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                    updateLst();
                    resetInput();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                resetInput();
                
            }
            else
            {
                errorProvider.SetError(txtInput, "Please enter data");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Make relevant input controls visible 
            resetInput();


            lblColumn.Visible = true;
            cmbDetail.Visible = true;
            btnUpdate.Visible = true;


        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            //Make relevant input controls visible 
            resetInput();
            lblInput.Text = "New Password: ";
            btnConfirm.Visible = true;
            lblInput.Visible = true;
            txtInput.Visible = true;
            lblOldPassword.Visible = true;
            txtOldPassword.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //Input validation
            if(txtOldPassword.Text!="")
            {
                if(txtInput.Text!="")
                {
                    try
                    {
                        conn.Open();

                        //Save old password into variable
                        command = new SqlCommand(@"SELECT Password FROM UserTable WHERE User_ID="+ID_+" ", conn);
                        SqlDataReader oldPasswordReader = command.ExecuteReader();

                        string oldPassword = "";
                        while(oldPasswordReader.Read())
                        {
                            oldPassword = oldPasswordReader.GetValue(0).ToString();
                        }
                        oldPasswordReader.Close();

                        //Check if correct old password is entered
                        //Update User password
                        if (oldPassword == txtOldPassword.Text)
                        {

                            SqlCommand setPasswordCommand = new SqlCommand(@"UPDATE UserTable SET Password ='" + txtInput.Text + "' WHERE User_ID = " + ID_ + "", conn);
                            setPasswordCommand.ExecuteNonQuery();
                            resetInput();
                            MessageBox.Show("Password updated");
                        }
                        else
                        {
                            errorProvider.SetError(txtOldPassword, "Incorrect Passowrd");
                        }

                        conn.Close();
                        updateLst();



                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    errorProvider.SetError(txtInput, "Please enter new password");
                }
            }
            else
            {
                errorProvider.SetError(txtOldPassword, "Please enter old password");
            }
            updateLst();

        }

        //Change button colour when hovering over it
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.LavenderBlush;
        }

        private void btnPassword_MouseEnter(object sender, EventArgs e)
        {
            btnPassword.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnPassword_MouseLeave(object sender, EventArgs e)
        {
            btnPassword.BackColor = Color.LavenderBlush;
        }

        private void btnPremium_MouseEnter(object sender, EventArgs e)
        {
            btnPremium.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnPremium_MouseLeave(object sender, EventArgs e)
        {
            btnPremium.BackColor = Color.LavenderBlush;
        }
    }
}
