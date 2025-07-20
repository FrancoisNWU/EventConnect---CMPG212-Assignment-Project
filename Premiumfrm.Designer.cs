
namespace _40723380_Verster_CMPG212_Exam
{
    partial class Premiumfrm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblUserEvent = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.lblnewName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAttendees = new System.Windows.Forms.TextBox();
            this.lblAttendees = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbRegistration = new System.Windows.Forms.CheckBox();
            this.cmbVenues = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(283, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Premium DashBoard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightCyan;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(42, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(154, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Host new event";
            this.toolTip.SetToolTip(this.btnNew, "Host a new event");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseEnter += new System.EventHandler(this.btnNew_MouseEnter);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightCyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(42, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit event";
            this.toolTip.SetToolTip(this.btnEdit, "Edit your event");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(367, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1055, 235);
            this.dataGridView.TabIndex = 3;
            // 
            // lblUserEvent
            // 
            this.lblUserEvent.AutoSize = true;
            this.lblUserEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEvent.Location = new System.Drawing.Point(835, 22);
            this.lblUserEvent.Name = "lblUserEvent";
            this.lblUserEvent.Size = new System.Drawing.Size(199, 20);
            this.lblUserEvent.TabIndex = 4;
            this.lblUserEvent.Text = "List of upcoming events";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProfile.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(42, 241);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(154, 30);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit Profile details";
            this.toolTip.SetToolTip(this.btnEditProfile, "Edit personal information and password");
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            this.btnEditProfile.MouseEnter += new System.EventHandler(this.btnEditProfile_MouseEnter);
            this.btnEditProfile.MouseLeave += new System.EventHandler(this.btnEditProfile_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(42, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete event";
            this.toolTip.SetToolTip(this.btnDelete, "Delete one of your events");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 721);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lblDateFormat);
            this.pnlInput.Controls.Add(this.cmbNames);
            this.pnlInput.Controls.Add(this.lblnewName);
            this.pnlInput.Controls.Add(this.txtPrice);
            this.pnlInput.Controls.Add(this.lblPrice);
            this.pnlInput.Controls.Add(this.txtAttendees);
            this.pnlInput.Controls.Add(this.lblAttendees);
            this.pnlInput.Controls.Add(this.lblColumn);
            this.pnlInput.Controls.Add(this.cmbColumn);
            this.pnlInput.Controls.Add(this.btnDeleteData);
            this.pnlInput.Controls.Add(this.btnadd);
            this.pnlInput.Controls.Add(this.btnConfirm);
            this.pnlInput.Controls.Add(this.txtDescription);
            this.pnlInput.Controls.Add(this.lblDescription);
            this.pnlInput.Controls.Add(this.lblMax);
            this.pnlInput.Controls.Add(this.txtCapacity);
            this.pnlInput.Controls.Add(this.lblCapacity);
            this.pnlInput.Controls.Add(this.cmbTime);
            this.pnlInput.Controls.Add(this.lblTime);
            this.pnlInput.Controls.Add(this.lblDate);
            this.pnlInput.Controls.Add(this.txtDate);
            this.pnlInput.Controls.Add(this.cbRegistration);
            this.pnlInput.Controls.Add(this.cmbVenues);
            this.pnlInput.Controls.Add(this.txtName);
            this.pnlInput.Controls.Add(this.lblVenue);
            this.pnlInput.Controls.Add(this.lblName);
            this.pnlInput.Location = new System.Drawing.Point(747, 329);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(397, 419);
            this.pnlInput.TabIndex = 7;
            this.pnlInput.Visible = false;
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(158, 7);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(128, 21);
            this.cmbNames.TabIndex = 25;
            // 
            // lblnewName
            // 
            this.lblnewName.AutoSize = true;
            this.lblnewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewName.Location = new System.Drawing.Point(1, 7);
            this.lblnewName.Name = "lblnewName";
            this.lblnewName.Size = new System.Drawing.Size(145, 17);
            this.lblnewName.TabIndex = 24;
            this.lblnewName.Text = "Select current Name: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 337);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 20);
            this.txtPrice.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 337);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(129, 17);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Entrance Price (R):";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAttendees
            // 
            this.txtAttendees.Location = new System.Drawing.Point(116, 296);
            this.txtAttendees.Name = "txtAttendees";
            this.txtAttendees.Size = new System.Drawing.Size(111, 20);
            this.txtAttendees.TabIndex = 21;
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendees.Location = new System.Drawing.Point(17, 296);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(100, 17);
            this.lblAttendees.TabIndex = 20;
            this.lblAttendees.Text = "Nr. of Guests: ";
            this.lblAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(6, 7);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(106, 17);
            this.lblColumn.TabIndex = 19;
            this.lblColumn.Text = "Column Select: ";
            this.lblColumn.Visible = false;
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Items.AddRange(new object[] {
            "Name",
            "Venue",
            "Register",
            "Date",
            "Time",
            "Capacity",
            "Description",
            "Guests_nr.",
            "Entrance_Price(R)"});
            this.cmbColumn.Location = new System.Drawing.Point(116, 6);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(146, 21);
            this.cmbColumn.TabIndex = 17;
            this.cmbColumn.Visible = false;
            this.cmbColumn.SelectedIndexChanged += new System.EventHandler(this.cmbColumn_SelectedIndexChanged);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.Location = new System.Drawing.Point(141, 78);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteData.TabIndex = 16;
            this.btnDeleteData.Text = "Delete";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Visible = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(141, 363);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 26);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(141, 376);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 26);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 255);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(17, 255);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(222, 221);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(76, 13);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Max capacity: ";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(116, 218);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 10;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(17, 221);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(70, 17);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Capacity: ";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "05:00 AM",
            "06:00 AM",
            "07:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM",
            ""});
            this.cmbTime.Location = new System.Drawing.Point(116, 179);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(100, 21);
            this.cmbTime.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(17, 180);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 17);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time: ";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(17, 147);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(116, 146);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(146, 20);
            this.txtDate.TabIndex = 5;
            // 
            // cbRegistration
            // 
            this.cbRegistration.AutoSize = true;
            this.cbRegistration.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegistration.Location = new System.Drawing.Point(20, 109);
            this.cbRegistration.Name = "cbRegistration";
            this.cbRegistration.Size = new System.Drawing.Size(158, 21);
            this.cbRegistration.TabIndex = 4;
            this.cbRegistration.Text = "   Registration Open:";
            this.cbRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRegistration.UseVisualStyleBackColor = true;
            // 
            // cmbVenues
            // 
            this.cmbVenues.FormattingEnabled = true;
            this.cmbVenues.Location = new System.Drawing.Point(116, 74);
            this.cmbVenues.Name = "cmbVenues";
            this.cmbVenues.Size = new System.Drawing.Size(146, 21);
            this.cmbVenues.TabIndex = 3;
            this.cmbVenues.SelectedIndexChanged += new System.EventHandler(this.cmbVenues_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(17, 78);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(57, 17);
            this.lblVenue.TabIndex = 1;
            this.lblVenue.Text = "Venue :";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Event Name: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 320);
            this.panel1.TabIndex = 8;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(367, 298);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(123, 30);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Show my events";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFormat.Location = new System.Drawing.Point(268, 151);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(86, 13);
            this.lblDateFormat.TabIndex = 26;
            this.lblDateFormat.Text = "e.g. 2023/01/01";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::_40723380_Verster_CMPG212_Exam.Properties.Resources.Event;
            this.pictureBox.Location = new System.Drawing.Point(213, 458);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(277, 226);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Premiumfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1434, 773);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUserEvent);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblHeader);
            this.Name = "Premiumfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium DashBoard";
            this.Load += new System.EventHandler(this.Premiumfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblUserEvent;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbRegistration;
        private System.Windows.Forms.ComboBox cmbVenues;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.ComboBox cmbTime;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAttendees;
        private System.Windows.Forms.TextBox txtAttendees;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Label lblnewName;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}