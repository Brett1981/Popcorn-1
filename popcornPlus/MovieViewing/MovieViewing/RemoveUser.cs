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
    public partial class RemoveUser : MetroFramework.Forms.MetroForm
    {
        private string id;
        private string name;
        private string idName;

        public RemoveUser()
        {
            InitializeComponent();
        }


        private void populateUserList()
        {
            cbEmployee.Items.Clear();

            SqlConnection conn = null;
            SqlDataReader rdr = null;

            try
            {
                conn = new SqlConnection(MovieListing.getConnString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_showAllUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   
                    name = (rdr["Name"].ToString());
                    idName = id + name;
                    cbEmployee.Items.Add(idName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbEmployee.SelectedIndex = 0;
        }

        private void RemoveUser_Load_1(object sender, EventArgs e)
        {
            populateUserList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Remove User "+cbEmployee.SelectedItem.ToString()+"!", "Confirm", MessageBoxButtons.YesNo);
            //MetroMessageBox.Show(this, "User Addedd", "Message");
            if (dialogResult == DialogResult.Yes)
            {
                idName = new string(idName.Where(x => char.IsDigit(x)).ToArray());
                SqlConnection conn = null;

                try
                {
                    conn = new SqlConnection(MovieListing.getConnString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_removeUser1", conn);
                    cmd.Parameters.Add(new SqlParameter("@employeeId", idName));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                populateUserList();
                
            } 
            
        }
    }
}
