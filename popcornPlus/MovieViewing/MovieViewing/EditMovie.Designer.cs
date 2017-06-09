namespace MovieViewing
{
    partial class EditMovie
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.tbPicturePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtGenre = new MetroFramework.Controls.MetroTextBox();
            this.txtRunTime = new MetroFramework.Controls.MetroTextBox();
            this.txtMovieID = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(220, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 23);
            this.btnClose.TabIndex = 84;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(221, 227);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 23);
            this.btnBrowse.TabIndex = 83;
            this.btnBrowse.Text = "BROWSE...";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbPicturePath
            // 
            // 
            // 
            // 
            this.tbPicturePath.CustomButton.Image = null;
            this.tbPicturePath.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbPicturePath.CustomButton.Name = "";
            this.tbPicturePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPicturePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPicturePath.CustomButton.TabIndex = 1;
            this.tbPicturePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPicturePath.CustomButton.UseSelectable = true;
            this.tbPicturePath.CustomButton.Visible = false;
            this.tbPicturePath.Lines = new string[0];
            this.tbPicturePath.Location = new System.Drawing.Point(89, 256);
            this.tbPicturePath.MaxLength = 32767;
            this.tbPicturePath.Name = "tbPicturePath";
            this.tbPicturePath.PasswordChar = '\0';
            this.tbPicturePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPicturePath.SelectedText = "";
            this.tbPicturePath.SelectionLength = 0;
            this.tbPicturePath.SelectionStart = 0;
            this.tbPicturePath.ShortcutsEnabled = true;
            this.tbPicturePath.Size = new System.Drawing.Size(257, 23);
            this.tbPicturePath.TabIndex = 82;
            this.tbPicturePath.UseSelectable = true;
            this.tbPicturePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPicturePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(89, 227);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 81;
            this.metroLabel9.Text = "Poster";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(89, 198);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(38, 19);
            this.metroLabel10.TabIndex = 80;
            this.metroLabel10.Text = "Price";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(221, 198);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(125, 23);
            this.txtPrice.TabIndex = 75;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(89, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 23);
            this.btnSubmit.TabIndex = 79;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(89, 82);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 78;
            this.metroLabel7.Text = "Movie ID";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(89, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 77;
            this.metroLabel6.Text = "Genre";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(89, 169);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Run Time";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 74;
            this.metroLabel1.Text = "Title";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(221, 111);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(125, 23);
            this.txtTitle.TabIndex = 71;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGenre
            // 
            // 
            // 
            // 
            this.txtGenre.CustomButton.Image = null;
            this.txtGenre.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtGenre.CustomButton.Name = "";
            this.txtGenre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenre.CustomButton.TabIndex = 1;
            this.txtGenre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenre.CustomButton.UseSelectable = true;
            this.txtGenre.CustomButton.Visible = false;
            this.txtGenre.Lines = new string[0];
            this.txtGenre.Location = new System.Drawing.Point(221, 140);
            this.txtGenre.MaxLength = 32767;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PasswordChar = '\0';
            this.txtGenre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenre.SelectedText = "";
            this.txtGenre.SelectionLength = 0;
            this.txtGenre.SelectionStart = 0;
            this.txtGenre.ShortcutsEnabled = true;
            this.txtGenre.Size = new System.Drawing.Size(125, 23);
            this.txtGenre.TabIndex = 72;
            this.txtGenre.UseSelectable = true;
            this.txtGenre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRunTime
            // 
            // 
            // 
            // 
            this.txtRunTime.CustomButton.Image = null;
            this.txtRunTime.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtRunTime.CustomButton.Name = "";
            this.txtRunTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRunTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRunTime.CustomButton.TabIndex = 1;
            this.txtRunTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRunTime.CustomButton.UseSelectable = true;
            this.txtRunTime.CustomButton.Visible = false;
            this.txtRunTime.Lines = new string[0];
            this.txtRunTime.Location = new System.Drawing.Point(221, 169);
            this.txtRunTime.MaxLength = 32767;
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.PasswordChar = '\0';
            this.txtRunTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRunTime.SelectedText = "";
            this.txtRunTime.SelectionLength = 0;
            this.txtRunTime.SelectionStart = 0;
            this.txtRunTime.ShortcutsEnabled = true;
            this.txtRunTime.Size = new System.Drawing.Size(125, 23);
            this.txtRunTime.TabIndex = 73;
            this.txtRunTime.UseSelectable = true;
            this.txtRunTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRunTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMovieID
            // 
            // 
            // 
            // 
            this.txtMovieID.CustomButton.Image = null;
            this.txtMovieID.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtMovieID.CustomButton.Name = "";
            this.txtMovieID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMovieID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMovieID.CustomButton.TabIndex = 1;
            this.txtMovieID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMovieID.CustomButton.UseSelectable = true;
            this.txtMovieID.CustomButton.Visible = false;
            this.txtMovieID.Lines = new string[0];
            this.txtMovieID.Location = new System.Drawing.Point(221, 82);
            this.txtMovieID.MaxLength = 32767;
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.PasswordChar = '\0';
            this.txtMovieID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMovieID.SelectedText = "";
            this.txtMovieID.SelectionLength = 0;
            this.txtMovieID.SelectionStart = 0;
            this.txtMovieID.ShortcutsEnabled = true;
            this.txtMovieID.Size = new System.Drawing.Size(125, 23);
            this.txtMovieID.TabIndex = 70;
            this.txtMovieID.UseSelectable = true;
            this.txtMovieID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMovieID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPicturePath);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRunTime);
            this.Controls.Add(this.txtMovieID);
            this.MaximizeBox = false;
            this.Name = "EditMovie";
            this.Resizable = false;
            this.Text = "EditMovie";
            this.Load += new System.EventHandler(this.EditMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox tbPicturePath;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtGenre;
        private MetroFramework.Controls.MetroTextBox txtRunTime;
        private MetroFramework.Controls.MetroTextBox txtMovieID;
    }
}