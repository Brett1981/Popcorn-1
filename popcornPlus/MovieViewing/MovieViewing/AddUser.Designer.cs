namespace MovieViewing
{
    partial class AddUser
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
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.chbClerk = new MetroFramework.Controls.MetroCheckBox();
            this.chbAdministrator = new MetroFramework.Controls.MetroCheckBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbLoginName = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(190, 59);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(139, 23);
            this.tbName.TabIndex = 19;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 50);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // chbClerk
            // 
            this.chbClerk.AutoSize = true;
            this.chbClerk.Location = new System.Drawing.Point(207, 180);
            this.chbClerk.Name = "chbClerk";
            this.chbClerk.Size = new System.Drawing.Size(50, 15);
            this.chbClerk.TabIndex = 15;
            this.chbClerk.Text = "Clerk";
            this.chbClerk.UseSelectable = true;
            this.chbClerk.CheckedChanged += new System.EventHandler(this.chbClerk_CheckedChanged_1);
            // 
            // chbAdministrator
            // 
            this.chbAdministrator.AutoSize = true;
            this.chbAdministrator.Location = new System.Drawing.Point(70, 180);
            this.chbAdministrator.Name = "chbAdministrator";
            this.chbAdministrator.Size = new System.Drawing.Size(96, 15);
            this.chbAdministrator.TabIndex = 14;
            this.chbAdministrator.Text = "Administrator";
            this.chbAdministrator.UseSelectable = true;
            this.chbAdministrator.CheckedChanged += new System.EventHandler(this.chbAdministrator_CheckedChanged);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(190, 126);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(139, 23);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbLoginName
            // 
            // 
            // 
            // 
            this.tbLoginName.CustomButton.Image = null;
            this.tbLoginName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.tbLoginName.CustomButton.Name = "";
            this.tbLoginName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLoginName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLoginName.CustomButton.TabIndex = 1;
            this.tbLoginName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLoginName.CustomButton.UseSelectable = true;
            this.tbLoginName.CustomButton.Visible = false;
            this.tbLoginName.Lines = new string[0];
            this.tbLoginName.Location = new System.Drawing.Point(190, 92);
            this.tbLoginName.MaxLength = 32767;
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.PasswordChar = '\0';
            this.tbLoginName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLoginName.SelectedText = "";
            this.tbLoginName.SelectionLength = 0;
            this.tbLoginName.SelectionStart = 0;
            this.tbLoginName.ShortcutsEnabled = true;
            this.tbLoginName.Size = new System.Drawing.Size(139, 23);
            this.tbLoginName.TabIndex = 12;
            this.tbLoginName.UseSelectable = true;
            this.tbLoginName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLoginName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 19);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(45, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 19);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "LoginName:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 325);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chbClerk);
            this.Controls.Add(this.chbAdministrator);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.Resizable = false;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroCheckBox chbClerk;
        private MetroFramework.Controls.MetroCheckBox chbAdministrator;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroTextBox tbLoginName;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblUserName;
    }
}