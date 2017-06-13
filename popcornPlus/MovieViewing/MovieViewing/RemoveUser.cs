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
            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_showAllUsers", MovieListing.useConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                { 
                    name = (rdr["Name"].ToString());
                    id = (rdr["Employee_ID"].ToString());
                    idName = id + name;
                    cbEmployee.Items.Add(idName);
                }
                MovieListing.useConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (cbEmployee.SelectedIndex > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Remove User " + cbEmployee.SelectedItem.ToString() + "!", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    idName = new string(idName.Where(x => char.IsDigit(x)).ToArray());
                    try
                    {
                        SqlCommand cmd = new SqlCommand("sp_removeUser1", MovieListing.useConnection());
                        cmd.Parameters.Add(new SqlParameter("@employeeId", idName));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        MovieListing.useConnection().Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    populateUserList();
                }
                
            }
            else
            {
                MessageBox.Show("Please select User.");
            }
            
        }
    }
}
