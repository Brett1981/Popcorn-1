using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


namespace MovieViewing
{
    public partial class MovieListing : MetroFramework.Forms.MetroForm
    {

        //movie listing connection string
        private static string connStringMovieListing = @"Server=(local)\SQLEXPRESS;Database=Popcorn;Trusted_Connection=True;";
        public static SqlConnection useConnection()// Return SQLiteConnection Object
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
            return conn;
        }

        public static string getConnString()
        {
            return connStringMovieListing;
        }
        public static Image getImage()
        {
            Image result = ml[selectedMovieId].getPoster();
            return result;
        }

        private static List<Movie> ml = new List<Movie>(); //movie list
        private static int selectedMovieId = -1;//variable used to identify a selected movie
        public static int getSelMovieId()
        {
            return selectedMovieId;
        }

        private static string selectedMovieName;//variable used to in seat booking form
        public static string getSelectedMovieName()
        {
            return selectedMovieName;
        }

        private static Image img;//image converted from image bytes that to be stored in movie object
        private static byte[] imgBytes;//image bytes read from dbase
        public static int SessionID;
        public static int MovieID;
        public MovieListing()
        {
            InitializeComponent();
            createMovieList();
            showMovie();
            MovieID = Convert.ToInt32(getSelMovieId());
            lblName.Text = Login.getUserName();
        }
        public void createMovieList()
        {
           // SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
               // conn = new SqlConnection(getConnString());
               // conn.Open();
                SqlCommand cmd = new SqlCommand("sp_movieList1", useConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    imgBytes = (byte[])rdr["Poster"];
                    MemoryStream ms = new MemoryStream(imgBytes);
                    img = Image.FromStream(ms);

                    Movie movie = new Movie((rdr["Movie_ID"].ToString()), (rdr["Title"].ToString()), (rdr["Genre"].ToString()),
                        (rdr["RunTime"].ToString()), img, (Convert.ToDouble(rdr["Price"].ToString())), (rdr["Director"].ToString()),
                        (rdr["Cast"].ToString()));

                    ml.Add(movie);
                }
                useConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void showMovie()
        {
            int movieCount = 0;
            int plocationH = 0;//i apachia
            int plocationL = 0;//i deshne
            int tlocationH = 186;//i apchia
            int tlocationL = 0;//i deshne
            int movieCountBreak = 0;
            int panelSizeH = 799;
            int panelSizeW = 450;

            foreach (Movie movie in ml)
            {
                if (movieCountBreak == 2)
                {
                    tlocationL = 0;
                    plocationL = 0;
                    plocationH += 263;
                    tlocationH += 263;
                    movieCountBreak = 0;
                    panelSizeH += 280;
                    //panelSizeW += 280;
                    movieListingPanel.Size = new Size(panelSizeW, panelSizeH);
                }

                PictureBox picture = new PictureBox
                {
                    Name = movieCount.ToString(),
                    Size = new Size(230, 180),//(i deshne, i apachia)
                    Location = new Point(plocationL, plocationH),
                    Image = ml[movieCount].getPoster(),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,

                };
                picture.MouseClick += new MouseEventHandler(picture_Click);//add on click even to dinamicly generated picturebox
                movieListingPanel.Controls.Add(picture);


                MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile()
                {
                    Name = "textBox" + movieCount,
                    Location = new Point(tlocationL, tlocationH),
                    Size = new Size(230, 50),//(i deshne, i apachia)
                    Text = ml[movieCount].getTitle(),
                    AutoSize = false,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                    //ReadOnly = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                movieListingPanel.Controls.Add(tile);

                movieCount++;
                movieCountBreak++;
                plocationL += 236;
                tlocationL += 236;

            }

        }

        private void picture_Click(object sender, MouseEventArgs e)
        {
            cbSession.Items.Clear();
            selectedMovieId = Int32.Parse(((PictureBox)sender).Name);
            populateSessionList(ml[selectedMovieId].getMovieId());
            //format currency
            string unfixedCurrency = ml[selectedMovieId].getTicketPrice().ToString();
            string fixedCurrency = "€" + unfixedCurrency;
            //populate textboxes with movie details
            tbTitle.Text = ml[selectedMovieId].getTitle();
            tbGenre.Text = ml[selectedMovieId].getGenre();
            lblRunTime.Text = ml[selectedMovieId].getRunTime();
            lblPrice.Text = fixedCurrency;
            //assign movies name to a variable thats used to access movie booking form
            selectedMovieName = ml[selectedMovieId].getTitle();
            MovieID = Convert.ToInt32(ml[selectedMovieId].getMovieId());
        }
        private void populateSessionList(string movieIdIn)
        {
            //using (SqlConnection conn = new SqlConnection(getConnString()))
            using(useConnection())
            {
               // conn.Open();
                SqlCommand cmd = new SqlCommand("Select Time from Session where Movie_ID =" + movieIdIn, useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime time = Convert.ToDateTime(reader["Time"].ToString());
                    cbSession.Items.Add(time.ToShortTimeString());
                }//End while
                useConnection().Close();
            }
        }
         
        public int getSession()
        {
            TimeSpan session = TimeSpan.Parse(cbSession.SelectedItem.ToString());
            int id =0;
            //using (SqlConnection conn = new SqlConnection(getConnString()))
            using(useConnection())
            {
               // conn.Open();
                SqlCommand cmd = new SqlCommand("Select Session_ID from Session where Movie_ID =" + MovieID + " and Time ='" + session + ":00'", useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Session_ID"]);

                }//End while
                useConnection().Close();
            }
            return id;
        }

        private void btnAddMovie_Click_1(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.FormClosed += new FormClosedEventHandler(Add_Movie_Closed);
            am.ShowDialog();
        }

        private void btnBookSeat_Click_1(object sender, EventArgs e)
        {
            if (selectedMovieId != -1 && cbSession.SelectedIndex > -1)
            {
                SeatBooking sb = new SeatBooking();
                MovieID = Convert.ToInt32(getSelMovieId());
                sb.FormClosed += new FormClosedEventHandler(form2_FormClosed);
                sb.ShowDialog();
            }
            else if (selectedMovieId != -1 && cbSession.SelectedIndex < 0)
            {
                MessageBox.Show("Please select session time.");
                test.Text = cbSession.SelectedIndex.ToString();
                test.Text += " " + MovieID.ToString();
            }
            else
            {
                MessageBox.Show("Please select movie.");
                test.Text = cbSession.SelectedIndex.ToString();
                test.Text += " "+MovieID.ToString(); 
                
            }
        }

        private void MovieListing_Load(object sender, EventArgs e)
        {
            if (Login.getUserPrivelege().Trim() == "c")
            {
                btnAddClerk.Enabled = false;
                btnAddMovie.Enabled = false;
                btnEditDetails.Enabled = false;
                btnRemoveClerk.Enabled = false;
                btnRemoveMovie.Enabled = false;
            }
        }

        private void cbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            SessionID = getSession();
        }

        private void btnEditDetails_Click_1(object sender, EventArgs e)
        { 
            if (MovieID != -1)
            {
                EditMovie myForm = new EditMovie();
                myForm.FormClosed += new FormClosedEventHandler(form2_FormClosed);
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Please select movie.");
            }            
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MovieID = -1;
            lblRunTime.Text = "";
            lblPrice.Text = "";
            cbSession.Items.Clear();         
        }
        void Add_Movie_Closed(object sender, FormClosedEventArgs e)
        {
            ml.Clear();
            createMovieList();
            showMovie();  
        }

        private void btnRemoveMovie_Click_1(object sender, EventArgs e)
        {
            if (MovieID !=- 1)
            {
                DialogResult dialogResult = MessageBox.Show("Confirm", "Remove Movie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   // using (SqlConnection conn = new SqlConnection(getConnString()))
                   using(useConnection())
                    {
                        //conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Session where Movie_ID=" + MovieID, useConnection());
                        {
                            cmd.ExecuteNonQuery();
                        }
                        useConnection().Close();
                    }

                    //using (SqlConnection conn = new SqlConnection(getConnString()))
                    using (useConnection())
                    {
                        //conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Movie where Movie_ID=" + MovieID, useConnection());
                        {
                            cmd.ExecuteNonQuery();
                        }
                        useConnection().Close();
                    }
                    ml.Clear();
                    createMovieList();
                    showMovie();
                } 
            }
            else
            {
                MessageBox.Show("Please select Movie");
            }
        }

        private void btnAddClerk_Click_1(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.ShowDialog();
        }

        private void btnRemoveClerk_Click_1(object sender, EventArgs e)
        {
            RemoveUser frm = new RemoveUser();
            frm.ShowDialog();
        }
    }
}
