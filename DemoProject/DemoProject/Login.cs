using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoProject
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }


        string str = @"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection Connect = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect = new SqlConnection(str);

            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = "select * from mtusers where username =  @username and password = @password and role = 'A'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text.Trim();
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text.Trim();
            object login = cmd.ExecuteScalar();

            if (login == null)
            {
                MessageBox.Show("Password or Username inconrect!", "👎🏽(ﾟヮﾟ)👎🏽");
            }
            else
            {
                
                MessageBox.Show("Welcome back, Master!", "(👍🏽ﾟヮﾟ)👍🏽");
                this.Hide();
                Menu fr2 = new Menu();
                fr2.ShowDialog();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Are you sure?", "(☞ﾟヮﾟ)☞", MessageBoxButtons.YesNo);
            if (yesno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private bool Check()
        {
            Connect = new SqlConnection(str);

            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = "select * from mtusers where username =  @username and password = @password and role = 'A'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text.Trim();
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text.Trim();
            object login = cmd.ExecuteScalar();

            if (login == null)
            {
                return false;
            }
            else
            {

                return true;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool Checked = false;
            Checked = Check();
            if(Checked)
            {
               UpdateUser fr = new UpdateUser();
                fr.ShowDialog();
            }
            else{
                MessageBox.Show("(❁´◡`❁)");
            }
        }
    
    }
}
