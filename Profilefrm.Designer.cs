
namespace _40723380_Verster_CMPG212_Exam
{
    partial class Profilefrm
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
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnPassword = new System.Windows.Forms.Button();
            this.cbPremium = new System.Windows.Forms.CheckBox();
            this.btnPremium = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.cmbDetail = new System.Windows.Forms.ComboBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlOption.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.btnPassword);
            this.pnlOption.Controls.Add(this.cbPremium);
            this.pnlOption.Controls.Add(this.btnPremium);
            this.pnlOption.Controls.Add(this.btnEdit);
            this.pnlOption.Location = new System.Drawing.Point(12, 84);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(219, 257);
            this.pnlOption.TabIndex = 0;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassword.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.Location = new System.Drawing.Point(15, 90);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(171, 30);
            this.btnPassword.TabIndex = 11;
            this.btnPassword.Text = "Change Password";
            this.toolTip.SetToolTip(this.btnPassword, "Change your password");
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            this.btnPassword.MouseEnter += new System.EventHandler(this.btnPassword_MouseEnter);
            this.btnPassword.MouseLeave += new System.EventHandler(this.btnPassword_MouseLeave);
            // 
            // cbPremium
            // 
            this.cbPremium.AutoSize = true;
            this.cbPremium.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPremium.Location = new System.Drawing.Point(43, 196);
            this.cbPremium.Name = "cbPremium";
            this.cbPremium.Size = new System.Drawing.Size(113, 17);
            this.cbPremium.TabIndex = 10;
            this.cbPremium.Text = "Switch to Premium";
            this.cbPremium.UseVisualStyleBackColor = true;
            this.cbPremium.Visible = false;
            this.cbPremium.CheckedChanged += new System.EventHandler(this.cbPremium_CheckedChanged);
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPremium.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremium.Location = new System.Drawing.Point(15, 156);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(171, 30);
            this.btnPremium.TabIndex = 4;
            this.btnPremium.Text = "Switch to Premium";
            this.toolTip.SetToolTip(this.btnPremium, "Switch account to premium");
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            this.btnPremium.MouseEnter += new System.EventHandler(this.btnPremium_MouseEnter);
            this.btnPremium.MouseLeave += new System.EventHandler(this.btnPremium_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(15, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Personal Details";
            this.toolTip.SetToolTip(this.btnEdit, "Change personal details");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(275, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Profile Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(27, 509);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Enabled = false;
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(377, 84);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(407, 199);
            this.lstOutput.TabIndex = 9;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblOldPassword);
            this.pnlInput.Controls.Add(this.txtOldPassword);
            this.pnlInput.Controls.Add(this.txtInput);
            this.pnlInput.Controls.Add(this.lblInput);
            this.pnlInput.Controls.Add(this.cmbDetail);
            this.pnlInput.Controls.Add(this.lblColumn);
            this.pnlInput.Controls.Add(this.btnConfirm);
            this.pnlInput.Controls.Add(this.btnUpdate);
            this.pnlInput.Location = new System.Drawing.Point(423, 303);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(361, 246);
            this.pnlInput.TabIndex = 10;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(9, 61);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(83, 15);
            this.lblOldPassword.TabIndex = 7;
            this.lblOldPassword.Text = "Old Password";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(98, 60);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(121, 20);
            this.txtOldPassword.TabIndex = 6;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(98, 104);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(121, 20);
            this.txtInput.TabIndex = 5;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(9, 105);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(47, 15);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Name: ";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDetail
            // 
            this.cmbDetail.FormattingEnabled = true;
            this.cmbDetail.Items.AddRange(new object[] {
            "Name",
            "Surname"});
            this.cmbDetail.Location = new System.Drawing.Point(98, 60);
            this.cmbDetail.Name = "cmbDetail";
            this.cmbDetail.Size = new System.Drawing.Size(121, 21);
            this.cmbDetail.TabIndex = 3;
            this.cmbDetail.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(64, 30);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(197, 17);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.Text = "Select what column to update:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(111, 163);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 26);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(111, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Profilefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(885, 583);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlOption);
            this.Name = "Profilefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Management";
            this.Load += new System.EventHandler(this.Profilefrm_Load);
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.CheckBox cbPremium;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cmbDetail;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.ToolTip toolTip;
    }
}