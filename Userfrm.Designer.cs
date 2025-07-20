
namespace _40723380_Verster_CMPG212_Exam
{
    partial class Userfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.cbRegister = new System.Windows.Forms.CheckBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbHost = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.cmbVenues = new System.Windows.Forms.ComboBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lbltickets = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHostID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(469, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(248, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "User DashBoard: ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1179, 160);
            this.dataGridView.TabIndex = 2;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.btnFinance);
            this.pnlOptions.Controls.Add(this.btnEditProfile);
            this.pnlOptions.Controls.Add(this.btnSearch);
            this.pnlOptions.Controls.Add(this.btnRegister);
            this.pnlOptions.Location = new System.Drawing.Point(21, 283);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(256, 263);
            this.pnlOptions.TabIndex = 3;
            // 
            // btnFinance
            // 
            this.btnFinance.BackColor = System.Drawing.Color.MintCream;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinance.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.Location = new System.Drawing.Point(46, 145);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(154, 30);
            this.btnFinance.TabIndex = 6;
            this.btnFinance.Text = "Financial report";
            this.toolTip.SetToolTip(this.btnFinance, "Get financial statement");
            this.btnFinance.UseVisualStyleBackColor = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            this.btnFinance.MouseEnter += new System.EventHandler(this.btnFinance_MouseEnter);
            this.btnFinance.MouseLeave += new System.EventHandler(this.btnFinance_MouseLeave);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.MintCream;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProfile.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(46, 202);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(154, 30);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit Profile Details";
            this.toolTip.SetToolTip(this.btnEditProfile, "Edit your profile details, including password");
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            this.btnEditProfile.MouseEnter += new System.EventHandler(this.btnEditProfile_MouseEnter);
            this.btnEditProfile.MouseLeave += new System.EventHandler(this.btnEditProfile_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MintCream;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(46, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search for event";
            this.toolTip.SetToolTip(this.btnSearch, "Search for event");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MintCream;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(46, 31);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 30);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register for event";
            this.toolTip.SetToolTip(this.btnRegister, "Register for new event");
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cbRegister);
            this.gbInput.Controls.Add(this.txtDate);
            this.gbInput.Controls.Add(this.cmbHost);
            this.gbInput.Controls.Add(this.lblVenue);
            this.gbInput.Controls.Add(this.cmbVenues);
            this.gbInput.Controls.Add(this.txtTickets);
            this.gbInput.Controls.Add(this.lbltickets);
            this.gbInput.Controls.Add(this.btnBook);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblDate);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Controls.Add(this.lblHostID);
            this.gbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInput.Location = new System.Drawing.Point(434, 282);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(464, 429);
            this.gbInput.TabIndex = 4;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // cbRegister
            // 
            this.cbRegister.AutoSize = true;
            this.cbRegister.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRegister.Location = new System.Drawing.Point(35, 225);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(164, 21);
            this.cbRegister.TabIndex = 16;
            this.cbRegister.Text = "Registration Available";
            this.cbRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRegister.UseVisualStyleBackColor = true;
            this.cbRegister.CheckedChanged += new System.EventHandler(this.cbRegister_CheckedChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(155, 181);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(135, 23);
            this.txtDate.TabIndex = 14;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // cmbHost
            // 
            this.cmbHost.FormattingEnabled = true;
            this.cmbHost.Location = new System.Drawing.Point(155, 79);
            this.cmbHost.Name = "cmbHost";
            this.cmbHost.Size = new System.Drawing.Size(121, 24);
            this.cmbHost.TabIndex = 13;
            this.cmbHost.SelectedIndexChanged += new System.EventHandler(this.cmbHost_SelectedIndexChanged);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(39, 308);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(53, 17);
            this.lblVenue.TabIndex = 12;
            this.lblVenue.Text = "Venue:";
            // 
            // cmbVenues
            // 
            this.cmbVenues.FormattingEnabled = true;
            this.cmbVenues.Location = new System.Drawing.Point(155, 305);
            this.cmbVenues.Name = "cmbVenues";
            this.cmbVenues.Size = new System.Drawing.Size(146, 24);
            this.cmbVenues.TabIndex = 11;
            this.cmbVenues.SelectedIndexChanged += new System.EventHandler(this.cmbVenues_SelectedIndexChanged);
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(155, 261);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(135, 23);
            this.txtTickets.TabIndex = 10;
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Location = new System.Drawing.Point(32, 267);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(100, 17);
            this.lbltickets.TabIndex = 9;
            this.lbltickets.Text = "Nr. of Tickets: ";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(180, 360);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(80, 28);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Select Date:  ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Event Name: ";
            // 
            // lblHostID
            // 
            this.lblHostID.AutoSize = true;
            this.lblHostID.Location = new System.Drawing.Point(39, 79);
            this.lblHostID.Name = "lblHostID";
            this.lblHostID.Size = new System.Drawing.Size(105, 17);
            this.lblHostID.TabIndex = 0;
            this.lblHostID.Text = "Select Host ID: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 671);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1047, 260);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(153, 35);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show personal data";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Userfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1230, 723);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblHeader);
            this.Name = "Userfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User DashBoard";
            this.Load += new System.EventHandler(this.Userfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHostID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.ComboBox cmbVenues;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbHost;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.CheckBox cbRegister;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.ToolTip toolTip;
    }
}