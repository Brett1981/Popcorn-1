namespace MovieViewing
{
    partial class MovieListing
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
            this.lblSession = new MetroFramework.Controls.MetroLabel();
            this.cbSession = new MetroFramework.Controls.MetroComboBox();
            this.btnRemoveClerk = new MetroFramework.Controls.MetroButton();
            this.btnAddClerk = new MetroFramework.Controls.MetroButton();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.btnRemoveMovie = new MetroFramework.Controls.MetroButton();
            this.btnAddMovie = new MetroFramework.Controls.MetroButton();
            this.btnEditDetails = new MetroFramework.Controls.MetroButton();
            this.btnBookSeat = new MetroFramework.Controls.MetroButton();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.tbGenre = new MetroFramework.Controls.MetroLabel();
            this.lblRunTime = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.tbTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.movieListingPanel = new MetroFramework.Controls.MetroPanel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.btnLogOff = new MetroFramework.Controls.MetroButton();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.test = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblSession
            // 
            this.lblSession.Location = new System.Drawing.Point(513, 140);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(92, 20);
            this.lblSession.TabIndex = 72;
            this.lblSession.Text = "Session:";
            // 
            // cbSession
            // 
            this.cbSession.FormattingEnabled = true;
            this.cbSession.ItemHeight = 23;
            this.cbSession.Location = new System.Drawing.Point(652, 140);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(121, 29);
            this.cbSession.TabIndex = 71;
            this.cbSession.UseSelectable = true;
            this.cbSession.SelectedIndexChanged += new System.EventHandler(this.cbSession_SelectedIndexChanged);
            // 
            // btnRemoveClerk
            // 
            this.btnRemoveClerk.Location = new System.Drawing.Point(652, 488);
            this.btnRemoveClerk.Name = "btnRemoveClerk";
            this.btnRemoveClerk.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveClerk.TabIndex = 69;
            this.btnRemoveClerk.Text = "REMOVE CLERK";
            this.btnRemoveClerk.UseSelectable = true;
            this.btnRemoveClerk.Click += new System.EventHandler(this.btnRemoveClerk_Click_1);
            // 
            // btnAddClerk
            // 
            this.btnAddClerk.Location = new System.Drawing.Point(513, 488);
            this.btnAddClerk.Name = "btnAddClerk";
            this.btnAddClerk.Size = new System.Drawing.Size(125, 50);
            this.btnAddClerk.TabIndex = 68;
            this.btnAddClerk.Text = "ADD CLERK";
            this.btnAddClerk.UseSelectable = true;
            this.btnAddClerk.Click += new System.EventHandler(this.btnAddClerk_Click_1);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(512, 442);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(265, 40);
            this.metroTile7.TabIndex = 67;
            this.metroTile7.Text = "MANAGEMENT";
            this.metroTile7.UseSelectable = true;
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(653, 310);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveMovie.TabIndex = 66;
            this.btnRemoveMovie.Text = "REMOVE MOVIE";
            this.btnRemoveMovie.UseSelectable = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click_1);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(513, 310);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(125, 50);
            this.btnAddMovie.TabIndex = 65;
            this.btnAddMovie.Text = "ADD NEW MOVIE";
            this.btnAddMovie.UseSelectable = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click_1);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(513, 377);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(126, 50);
            this.btnEditDetails.TabIndex = 63;
            this.btnEditDetails.Text = "EDIT DETAILS";
            this.btnEditDetails.UseSelectable = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click_1);
            // 
            // btnBookSeat
            // 
            this.btnBookSeat.Location = new System.Drawing.Point(512, 181);
            this.btnBookSeat.Name = "btnBookSeat";
            this.btnBookSeat.Size = new System.Drawing.Size(125, 50);
            this.btnBookSeat.TabIndex = 62;
            this.btnBookSeat.Text = "BOOK SEAT";
            this.btnBookSeat.UseSelectable = true;
            this.btnBookSeat.Click += new System.EventHandler(this.btnBookSeat_Click_1);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(513, 264);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(265, 40);
            this.metroTile6.TabIndex = 61;
            this.metroTile6.Text = "ACTION";
            this.metroTile6.UseSelectable = true;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(610, -24);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(167, 20);
            this.tbGenre.TabIndex = 60;
            this.tbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRunTime
            // 
            this.lblRunTime.Location = new System.Drawing.Point(610, 88);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(167, 20);
            this.lblRunTime.TabIndex = 59;
            this.lblRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(611, 108);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(167, 20);
            this.lblPrice.TabIndex = 55;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(610, -44);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(167, 20);
            this.tbTitle.TabIndex = 54;
            this.tbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(512, -24);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(92, 20);
            this.metroLabel11.TabIndex = 53;
            this.metroLabel11.Text = "Genre: ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(512, 75);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(92, 20);
            this.metroLabel10.TabIndex = 52;
            this.metroLabel10.Text = "Run Time: ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(512, 108);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 20);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Ticket Price: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(512, -44);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 20);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "Title: ";
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(512, -87);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(265, 40);
            this.metroTile5.TabIndex = 46;
            this.metroTile5.Text = "DETAILS";
            this.metroTile5.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(142, -120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(380, 30);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Movie Viewing";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(65, -110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 20);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "GABOR";
            // 
            // movieListingPanel
            // 
            this.movieListingPanel.HorizontalScrollbarBarColor = true;
            this.movieListingPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.movieListingPanel.HorizontalScrollbarSize = 10;
            this.movieListingPanel.Location = new System.Drawing.Point(42, 75);
            this.movieListingPanel.Name = "movieListingPanel";
            this.movieListingPanel.Size = new System.Drawing.Size(383, 502);
            this.movieListingPanel.TabIndex = 73;
            this.movieListingPanel.VerticalScrollbarBarColor = true;
            this.movieListingPanel.VerticalScrollbarHighlightOnWheel = false;
            this.movieListingPanel.VerticalScrollbarSize = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(-8, -24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 0);
            this.lblUser.TabIndex = 74;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackgroundImage = global::MovieViewing.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout;
            this.btnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOff.Location = new System.Drawing.Point(23, -121);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(36, 31);
            this.btnLogOff.TabIndex = 64;
            this.btnLogOff.UseSelectable = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 0);
            this.lblName.TabIndex = 75;
            // 
            // test
            // 
            // 
            // 
            // 
            this.test.CustomButton.Image = null;
            this.test.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.test.CustomButton.Name = "";
            this.test.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.test.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.test.CustomButton.TabIndex = 1;
            this.test.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.test.CustomButton.UseSelectable = true;
            this.test.CustomButton.Visible = false;
            this.test.Lines = new string[0];
            this.test.Location = new System.Drawing.Point(559, 33);
            this.test.MaxLength = 32767;
            this.test.Name = "test";
            this.test.PasswordChar = '\0';
            this.test.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.test.SelectedText = "";
            this.test.SelectionLength = 0;
            this.test.SelectionStart = 0;
            this.test.ShortcutsEnabled = true;
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 76;
            this.test.UseSelectable = true;
            this.test.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.test.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MovieListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.test);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.movieListingPanel);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.cbSession);
            this.Controls.Add(this.btnRemoveClerk);
            this.Controls.Add(this.btnAddClerk);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.btnBookSeat);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.lblRunTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "MovieListing";
            this.Text = "MovieListing";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MovieListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSession;
        private MetroFramework.Controls.MetroComboBox cbSession;
        private MetroFramework.Controls.MetroButton btnRemoveClerk;
        private MetroFramework.Controls.MetroButton btnAddClerk;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroButton btnRemoveMovie;
        private MetroFramework.Controls.MetroButton btnAddMovie;
        private MetroFramework.Controls.MetroButton btnLogOff;
        private MetroFramework.Controls.MetroButton btnEditDetails;
        private MetroFramework.Controls.MetroButton btnBookSeat;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroLabel tbGenre;
        private MetroFramework.Controls.MetroLabel lblRunTime;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel tbTitle;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel movieListingPanel;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox test;

    }
}