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
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        private string name;
        private string LoginName;
        private string password;
        private string privelege;

        public AddUser()
        {
            InitializeComponent();
        }

        private void addUser()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_addUser2", MovieListing.useConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", LoginName));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@userType", privelege));
                cmd.Parameters.Add(new SqlParameter("@name", name));

                cmd.ExecuteNonQuery();
                MovieListing.useConnection().Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("User Name Already Exist.");
            }
        }

        private void AddUser_Load_1(object sender, EventArgs e)
        {
            chbClerk.Checked = true;
        }

        private void chbClerk_CheckedChanged_1(object sender, EventArgs e)
        {
            chbAdministrator.Checked = !chbClerk.Checked;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(tbName.Text, out n);
            if (isNumeric == false)
            {

                LoginName = tbLoginName.Text;
                password = tbPassword.Text;
                name = tbName.Text;

                if (chbAdministrator.Checked == true)
                {
                    privelege = "a";
                }
                else
                {
                    privelege = "c";
                }

                addUser();
            }
            else
            {
                MessageBox.Show("Error : Name Can't Contain Numeric Characters");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            chbClerk.Checked = !chbAdministrator.Checked;
        }
    }
}
