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

namespace MovieViewing
{
    public partial class EditMovie : MetroFramework.Forms.MetroForm
    {
        //connection string
        private static string connectionString = MovieListing.getConnString();
        private string selectedMovieId = MovieListing.MovieID.ToString();
        //selected movie       
        private string imagePath;

        public EditMovie()
        {
            InitializeComponent();
            
        }
        private void populateTextBoxes()
        {
            txtMovieID.ReadOnly = true;
            tbPicturePath.ReadOnly = true;

           // SqlConnection conn = null;
            SqlDataReader rdr = null;
            string unfixedTime = null;
            string fixedTime;
            string unfixedCurrency = null;
            string fixedCurrency;

            try
            {
               // conn = new SqlConnection(connectionString);
               // conn.Open();
                SqlCommand cmd = new SqlCommand("sp_viewEditMovie", MovieListing.useConnection());
                cmd.Parameters.Add(new SqlParameter("@id", selectedMovieId));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtTitle.Text = rdr["Title"].ToString();
                    txtGenre.Text = rdr["Genre"].ToString();
                    unfixedTime = rdr["RunTime"].ToString();
                    unfixedCurrency = rdr["Price"].ToString();
                }
                MovieListing.useConnection().Close();
                fixedTime = unfixedTime.Substring(0, 8);
                txtRunTime.Text = fixedTime;
                fixedCurrency = unfixedCurrency.Substring(0, 2);
                txtPrice.Text = fixedCurrency;
                txtMovieID.Text = selectedMovieId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //SqlConnection conn = null;
            SqlDataReader rdr = null;
            if (txtTitle.Text != null && txtGenre.Text != null && txtRunTime.Text != null && txtPrice.Text != null &&
               imagePath != null)
            {
                try
                {
                   // conn = new SqlConnection(connectionString);
                    //conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_editMovie1", MovieListing.useConnection());
                    cmd.Parameters.Add(new SqlParameter("@id", selectedMovieId));
                    cmd.Parameters.Add(new SqlParameter("@title", txtTitle.Text));
                    cmd.Parameters.Add(new SqlParameter("@genre", txtGenre.Text));
                    cmd.Parameters.Add(new SqlParameter("@runTime", txtRunTime.Text));
                    cmd.Parameters.Add(new SqlParameter("@ticketPrice", txtPrice.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();
                    rdr.Close();

                    SqlCommand cmd2 = new SqlCommand("sp_addMovie2", MovieListing.useConnection());
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add(new SqlParameter("@poster", imagePath));
                    cmd2.Parameters.Add(new SqlParameter("@id", selectedMovieId));

                    cmd2.ExecuteNonQuery();
                    MovieListing.useConnection().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
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
                MessageBox.Show(imagePath.ToString());
                tbPicturePath.Text = imagePath;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            populateTextBoxes();
        }   
    }
}
