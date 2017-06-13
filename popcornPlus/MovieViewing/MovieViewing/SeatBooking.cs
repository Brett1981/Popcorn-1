using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;


namespace MovieViewing
{
    public partial class SeatBooking : MetroFramework.Forms.MetroForm
    {
        List<Session> sessionList = new List<Session>();
        List<Seat> seatList = new List<Seat>();
        string movieTitle;
        string runTime;
        decimal price;
        decimal totalPrice;
        public static string Title;
        public static string Runtime;
        public static string Price;
        public static string Totalprice;
        public static string Date;
        public static string Seats;
        public static string Auditorium;
        DateTime today = DateTime.Today;
        public SeatBooking()
        {
            InitializeComponent();
            getSession();
            generateSeats();
            sessionTimeAndScreen();
            creatTicket();
            generateButtons();
            picBoxLogo.Image = MovieListing.getImage();
            lblName.Text = Login.getUserName();
            btnLogOf.BackgroundImage = Properties.Resources.logoff;
            pictureBox2.BackgroundImage = Properties.Resources.PopcornLogo;

        }  
        
        void on_Click_Seat(Object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                foreach(Seat i in seatList)
                {
                    if (i.Reserved && ((int)button.Tag == i.SeatNumber))
                    { 
                        button.ForeColor = Color.Green;
                        button.BackColor = Color.White;
                        i.Reserved = false;
                        lblTotal.Text = (totalPrice -= price).ToString("F");
                        lblSeat.Text = lblSeat.Text.Replace(" " + i.SeatNumber, "");

                    }
                    else if(!i.Reserved && ((int)button.Tag == i.SeatNumber))
                    {
                        button.ForeColor = Color.Red;
                        button.BackColor = Color.Gold;
                        i.Reserved = true;
                        lblTotal.Text = (totalPrice += price).ToString("F");
                        lblSeat.Text += " " + i.SeatNumber.ToString();
                    }
                }
            }
        }

        public void generateButtons()
        {
            foreach (Seat i in seatList)
            {
                Button BtnNew = new Button();
                BtnNew.Height = 100;
                BtnNew.Width = 100;
                BtnNew.Text = "Seat\n" + (i.SeatNumber);
                BtnNew.Tag = i.SeatNumber;
                BtnNew.ForeColor = Color.Green;
                if (i.Reserved)
                {
                    BtnNew.ForeColor = Color.Red;
                    BtnNew.BackColor = Color.Gold;
                    BtnNew.Enabled = false;
                }
                BtnNew.Click += new EventHandler(on_Click_Seat);
                tablePanel.Controls.Add(BtnNew);
            }
        }

        // Connect to the database.
        public void getSession()
        {
            using(MovieListing.useConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * from Session where Session_ID = "+MovieListing.SessionID, MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Session temp = new Session();
                    temp.SessionID = Convert.ToInt32(reader["Session_ID"]);
                    temp.Time = reader["Time"].ToString();
                    temp.MovieID = Convert.ToInt32(reader["Movie_ID"]);
                    temp.SeatPlan = Convert.ToInt32(reader["SeatPlan_ID"]);
                    temp.AuditoriumID = Convert.ToInt32(reader["Auditorium_ID"]);
                    sessionList.Add(temp);
                }//End while
                MovieListing.useConnection().Close();
            }
        }
        public void generateSeats()
        {
            using(MovieListing.useConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Seat.Seat_ID, Seat.Reserved, Seat.SeatPlan_ID, Seat.Number from(Session inner join Seat on Session.SeatPlan_ID =Seat.SeatPlan_ID and Session.Session_ID ="+MovieListing.SessionID+")", MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Seat seat = new Seat();
                    seat.ID = Convert.ToInt32(reader["Seat_ID"]);
                    seat.Reserved = Convert.ToBoolean(reader["Reserved"]);
                    seat.SeatPlanID = Convert.ToInt32(reader["SeatPlan_ID"]);
                    seat.SeatNumber = Convert.ToInt32(reader["Number"]);
                    seatList.Add(seat);
                    
                }//End while
                MovieListing.useConnection().Close();
            }
        }
        private void metroButton19_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void sessionTimeAndScreen()
        {
            foreach (Session i in sessionList)
            {
                txtTime.Text = i.Time.ToString();
                txtScreen.Text = i.AuditoriumID.ToString();
            }
        }
       
        public void creatTicket()
        {
            using(MovieListing.useConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * from Movie where Movie_ID = "+MovieListing.MovieID, MovieListing.useConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movieTitle = reader["Title"].ToString();
                    runTime = reader["RunTime"].ToString();
                    price = Convert.ToDecimal(reader["Price"]);
                }//End while
                MovieListing.useConnection().Close();
                foreach (Session i in sessionList)
                {
                    lblScreen.Text = i.AuditoriumID.ToString();
                    lblDate.Text = today.ToShortDateString()+"  "+ i.Time;
                }
            }
            lblTitle.Text = movieTitle;
            lblRunTime.Text = runTime;
            lblPrice.Text = price.ToString("F");
        }
       
            private void metroButton18_Click(object sender, EventArgs e)
            {
                Title = lblTitle.Text;
                Runtime = lblRunTime.Text;
                Price = lblPrice.Text;
                Totalprice = lblTotal.Text;
                Date = lblDate.Text;
                Seats = lblSeat.Text;
                Auditorium= lblScreen.Text;
                updateSeats();
                Receipt myForm = new Receipt();
                myForm.Show();
            }
            private void updateSeats()
            {
                foreach(Seat i in seatList){
                    using(MovieListing.useConnection())
                    {
                        SqlCommand cmd = new SqlCommand("update seat set Reserved =@res where Seat_ID = @ID", MovieListing.useConnection());
                        {
                            cmd.Parameters.AddWithValue("@res", i.Reserved);
                            cmd.Parameters.AddWithValue("@id", i.ID);
                            cmd.ExecuteNonQuery();
                        MovieListing.useConnection().Close(); ;
                        }   
                    }
                }
            }

            private void btnBack_Click(object sender, EventArgs e)
            {  
                this.Close();
            }

            private void btnLogOf_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show("Log off " + Login.getUserName() + "?", "Confirm!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

    }

