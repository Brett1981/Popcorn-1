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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private static bool authenticate = false;
        //currently logged on users name/surname
        private static string userName;
        public static string getUserName()
        {
            return userName;
        }
        //currently logged on users id   
        private static string userId;
        public static string getUserId()
        {
            return userName;
        }
        //user privelge...admin or clerk
        private static string userPrivelege = null;
        public static string getUserPrivelege()
        {
            return userPrivelege;
        }
        public static void setUserPrivelege(string idIn)
        {
            userPrivelege = idIn;
        }

        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '●';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        public string login()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            string result = null;

            try
            {
                conn = new SqlConnection(MovieListing.getConnString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_logIn4", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@username", tbUserName.Text));
                cmd.Parameters.Add(new SqlParameter("@password", tbPassword.Text));

                var outParam = new SqlParameter("@result", SqlDbType.VarChar, -1);
                var outParam2 = new SqlParameter("@result2", SqlDbType.VarChar, -1);
                var outParam3 = new SqlParameter("@result3", SqlDbType.VarChar, -1);
                var outParam4 = new SqlParameter("@result4", SqlDbType.VarChar, -1);
                outParam.Direction = ParameterDirection.Output;
                outParam2.Direction = ParameterDirection.Output;
                outParam3.Direction = ParameterDirection.Output;
                outParam4.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                cmd.Parameters.Add(outParam2);
                cmd.Parameters.Add(outParam3);
                cmd.Parameters.Add(outParam4);

                cmd.ExecuteNonQuery();

                rdr = cmd.ExecuteReader();

                if (cmd.Parameters["@result"].Value.ToString() == tbUserName.Text + " " + tbPassword.Text)
                {
                    authenticate = true;
                    userName = cmd.Parameters["@result2"].Value.ToString();
                    userId = cmd.Parameters["@result3"].Value.ToString();
                    userPrivelege = cmd.Parameters["@result4"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Error 001: Invalid Username Or Password");
                    authenticate = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnLogin_Click(this, new EventArgs());
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();

            if (authenticate == true)
            {
                ActiveForm.Hide();
                MovieListing ml = new MovieListing();
                ml.ShowDialog();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
