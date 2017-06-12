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
using MetroFramework;
using System.IO;

namespace MovieViewing
{
    public partial class AddMovie : MetroFramework.Forms.MetroForm
    {

        /* Instance Variable*/
        private int numberOfSeats;
       // private string image;
        private int auditoriumID;
        private int seatPlanID;
        private int movie_ID;
        private TimeSpan time1;
        private TimeSpan time2;
        private TimeSpan time3;
        private string imagePath;
        //private string connString = @"Server=(local)\SQLEXPRESS;Database=Popcorn;Trusted_Connection=True;";
        private List<string> sessions = new List<string>();

        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
        }

        public void populateComboBoxes()
        {
            cbTime1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTime2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTime3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTime1.SelectedIndex = 0;
            cbTime2.SelectedIndex = 0;
            cbTime3.SelectedIndex = 0;
        }

        /* NON QUERY SQL COMMANDS TO INSERT RECORDS INTO DATABASE TABLES BY PASSING VALUES FROM THE ADD MOVIE FORM*/
        public void addMovie()
        {
            //SqlConnection conn = null;

            try
            {
               // conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("sp_addMovie6", MovieListing.useConnection());
                cmd.CommandType = CommandType.StoredProcedure;

               // Open();

                cmd.Parameters.Add(new SqlParameter("@title", txtTitle.Text));
                cmd.Parameters.Add(new SqlParameter("@genre", txtGenre.Text));
                cmd.Parameters.Add(new SqlParameter("@runTime", txtRunTime.Text));
                cmd.Parameters.Add(new SqlParameter("@ticketPrice", txtPrice.Text));
                cmd.Parameters.Add(new SqlParameter("@timeShown1", time1));
                cmd.Parameters.Add(new SqlParameter("@timeShown2", time2));
                cmd.Parameters.Add(new SqlParameter("@timeShown3", time3));

                cmd.ExecuteNonQuery();
                MovieListing.useConnection().Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void addSeat()
        {
            /*
            for (int i = 0; i < getNumberOfSeats(); i++)
            {
                Seat seat = new Seat(seatPlanID, false, (i + 1));
                using (SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=Popcorn;Trusted_Connection=yes;"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Seat (Number, Reserved, SeatPlan_ID) values(@num, @res, @plan_ID )", conn);
                    {
                        cmd.Parameters.AddWithValue("@num", (i + 1));
                        cmd.Parameters.AddWithValue("@res", false);
                        cmd.Parameters.AddWithValue("@plan_ID", seatPlanID);
                        cmd.ExecuteNonQuery();
                        //MetroMessageBox.Show(this, "User Addedd", "Message");
                        conn.Close();
                    }
                }
            }
            */
            for (int i = 0; i < getNumberOfSeats(); i++)
            {
                Seat seat = new Seat(seatPlanID, false, (i + 1));
               // SqlConnection conn = null;
                try
                {
                    //conn = new SqlConnection(MovieListing.getConnString());
                   // conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_addSeat", MovieListing.useConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@number", (i + 1)));
                    cmd.Parameters.Add(new SqlParameter("@reserved", false));
                    cmd.Parameters.Add(new SqlParameter("@planId", seatPlanID));
                    cmd.ExecuteNonQuery();
                    MovieListing.useConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void addSeatPlan()
        {
            
            using (MovieListing.useConnection())
            {
                SqlCommand cmd = new SqlCommand("Insert into SeatPLan(Auditorium_ID) values(@audit)", MovieListing.useConnection());
                {
                    cmd.Parameters.AddWithValue("@audit", auditoriumID);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                MovieListing.useConnection().Close();
            }
            

        }
        public void addSession(TimeSpan timeIn)
        {
            //SqlConnection conn = null;

            try
            {
                //conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("sp_addSession", MovieListing.useConnection());
                cmd.CommandType = CommandType.StoredProcedure;

               // conn.Open();

                cmd.Parameters.Add(new SqlParameter("@movieID", movie_ID));
                cmd.Parameters.Add(new SqlParameter("@planID", seatPlanID));
                cmd.Parameters.Add(new SqlParameter("@audit", auditoriumID));
                cmd.Parameters.Add(new SqlParameter("@time", timeIn));

                cmd.ExecuteNonQuery();
                MovieListing.useConnection().Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        /* METHODS TO GET DATA FROM DATABASE AND STORE IN THE INSTANCE VARIABLES*/
        public int getMovie_ID()
        {
            //SqlConnection conn = null;
           // conn = new SqlConnection(connString);

            using (MovieListing.useConnection())
            {
                //conn.Open();

                SqlCommand cmd = new SqlCommand("Select Top 1 * from Movie order by Movie_ID desc", MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movie_ID = Convert.ToInt32(reader["Movie_ID"]);
                }//End while
                MovieListing.useConnection().Close();
            }

            insertPicture();


            return movie_ID;
        }

        public void insertPicture()
        {
           // SqlConnection conn = null;
           // conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd2 = new SqlCommand("sp_addMovie2", MovieListing.useConnection());
                cmd2.CommandType = CommandType.StoredProcedure;
                //  conn.Open();
                 cmd2.Parameters.Add(new SqlParameter("@poster", imagePath));
                cmd2.Parameters.Add(new SqlParameter("@id", movie_ID));
                cmd2.ExecuteNonQuery();
            MovieListing.useConnection().Close();
            }
            catch(Exception e){
                MessageBox.Show("Image could not be opened.");

            }

        }
        public int getNumberOfSeats()
        {
            //using (SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=Popcorn;Trusted_Connection=yes;"))
            using(MovieListing.useConnection())
            {
               // conn.Open();

                SqlCommand cmd = new SqlCommand("Select NumberOfSeats from Auditorium where Audtorium_ID =" + auditoriumID, MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numberOfSeats = Convert.ToInt32(reader["NumberOfSeats"]);
                }//End while
                MovieListing.useConnection().Close();
            }
            return numberOfSeats;
        }

        public int getSeatPlanID()
        {
            //using (SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=Popcorn;Trusted_Connection=yes;"))
            using(MovieListing.useConnection())
            {
               // conn.Open();

                SqlCommand cmd = new SqlCommand("Select Top 1 * from SeatPlan order by SeatPlan_ID desc", MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seatPlanID = Convert.ToInt32(reader["SeatPlan_ID"]);
                }//End while
                MovieListing.useConnection().Close();
            }
            return seatPlanID;
        }


        /* HELPER MTHOD TO INSERT IMAGE INTO THE DATABASE TABLE* {PASS IN IMAGE PATH}*/
        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void getUsedSession()
        {
           // SqlConnection conn = null;
            SqlDataReader rdr = null;

            string unfixedTime;
            string auditorium;
            string fixedTime;
            string usedTimeAuditorium;

            try
            {
                //conn = new SqlConnection(connString);
              //  conn.Open();
                SqlCommand cmd = new SqlCommand("sp_getUsedSession1", MovieListing.useConnection());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    auditorium = (rdr["Auditorium_ID"].ToString());
                    unfixedTime = (rdr["Time"].ToString());
                    fixedTime = unfixedTime.Substring(0, 5);
                    usedTimeAuditorium = auditorium + fixedTime;
                    sessions.Add(usedTimeAuditorium);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getUsedSession();

            if (sessions.Contains(txtAuditorium.Text + cbTime1.Text) || sessions.Contains(txtAuditorium.Text + cbTime2.Text) || sessions.Contains(txtAuditorium.Text + cbTime3.Text))
            {
                MessageBox.Show("Error 009: Movie Already Exists, On Screen, At This Time.");
            }

            else
            {

                if (cbTime1.Text != "unselected")
                {
                    time1 = TimeSpan.Parse(cbTime1.Text);
                }
                else
                {
                    time1 = TimeSpan.Parse("00:00");
                }
                if (cbTime2.Text != "unselected")
                {
                    time2 = TimeSpan.Parse(cbTime2.Text);
                }
                else
                {
                    time2 = TimeSpan.Parse("00:00");
                }
                if (cbTime3.Text != "unselected")
                {
                    time3 = TimeSpan.Parse(cbTime3.Text);
                }
                else
                {
                    time3 = TimeSpan.Parse("00:00");
                }

                auditoriumID = Convert.ToInt32(txtAuditorium.Text);

                addMovie();
                getMovie_ID();

                if (cbTime1.Text != "unselected")
                {
                    addSeatPlan();
                    getSeatPlanID();
                    addSeat();
                    addSession(time1);
                }
                if (cbTime2.Text != "unselected")
                {
                    addSeatPlan();
                    getSeatPlanID();
                    addSeat();
                    addSession(time2);
                }
                if (cbTime3.Text != "unselected")
                {
                    addSeatPlan();
                    getSeatPlanID();
                    addSeat();
                    addSession(time3);
                }
                Close();
            }
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog browseImage = new OpenFileDialog();
            browseImage.Title = "Find your image";
            browseImage.InitialDirectory = @"c:\";
            browseImage.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            browseImage.FilterIndex = 2;
            browseImage.RestoreDirectory = true;

            if (browseImage.ShowDialog() == DialogResult.OK)
            {
                imagePath = browseImage.FileName;
                tbPicturePath.Text = imagePath;
            }

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

