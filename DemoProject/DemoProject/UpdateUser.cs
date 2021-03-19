using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace DemoProject
{
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            Connect = new SqlConnection(str);
            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = @"Select username From mtusers";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            string kq = "";
            while (reader.Read())
            {
                kq = kq + reader[0].ToString() + "\r\n";
                txtList.Text = kq;
            }
            reader.Close();
        }

        string str = @"Data Source=MYFUKINPC;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection Connect = null;
       
        private void UpdateUser_Load(object sender, EventArgs e)
        {
            DisplayData();

            
        }

        private void cboExecute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExecute.Text == "Add New")
            {
                txtList.Enabled = false;
                txtFullname.Enabled = true;
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
                txtSearch.Enabled = false;
                cboExecute.Enabled = true;
                btnSave.Enabled = true;
                cboRole.Enabled = true;
                btnSearch.Enabled = false;
                btnDelete.Enabled = false;
                modifieddate.Enabled = true;
            }
             else if (cboExecute.Text == "Update")
            {
                txtList.Enabled = false;
                txtFullname.Enabled = true;
                txtPassword.Enabled = true;
                txtUsername.Enabled = false;
                txtSearch.Enabled = true;
                cboExecute.Enabled = true;
                btnSave.Enabled = true;
                cboRole.Enabled = true;
                btnSearch.Enabled = true;
                btnDelete.Enabled = false;
                modifieddate.Enabled = true;
            }
            else if (cboExecute.Text == "Delete")
            {

                txtList.Enabled = false;
                txtFullname.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
                txtSearch.Enabled = true;
                cboExecute.Enabled = true;
                btnSave.Enabled = false;
                cboRole.Enabled = false;
                btnSearch.Enabled = true;
                btnDelete.Enabled = true;
                modifieddate.Enabled = false;
            }
          
            txtSearch.Text = "";
            txtFullname.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            Connect = new SqlConnection(str);
            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
          
            //Add new

            if (cboExecute.Text == "Add New")
            {
                try
                {
                    cmd.CommandText = @"insert into mtusers(username,password,fullname,role,modifieddate)
                                                values(@username,@password,@fullname,@role,@modifieddate)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text.Trim();
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text.Trim();
                    cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = txtFullname.Text.Trim();
                    cmd.Parameters.Add("@modifieddate", SqlDbType.DateTime).Value =modifieddate.Value;


                    //if (cboRole.SelectedText == "Administrator")
                    //{
                    //    cboRole.Text = "A";
                    //}
                    //else if (cboRole.SelectedText == "User")
                    //{
                    //    cboRole.Text = "U";
                    //}
                    cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = cboRole.Text.Trim();
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");

                    DisplayData();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            else if (cboExecute.Text == "Update")
            {
                 
                cmd.CommandText = @"update mtusers set password = @password,fullname = @fullname,role = @role where username =@username";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtList.Text;
                cmd.Parameters.Add("@password",SqlDbType.NVarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = txtFullname.Text;
                cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = cboRole.Text;
                object kq = cmd.ExecuteScalar();
                MessageBox.Show("Success");
               
                DisplayData();

            }
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Connect = new SqlConnection(str);
            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;

            cmd.CommandText = @"Select username From MTUsers where username like @username";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtSearch.Text;
         
            object kq = cmd.ExecuteScalar();
            if (kq == null)
            {
                txtList.Text = "404 Not Found";
            }
            else
            {
                txtList.Text = kq.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connect = new SqlConnection(str);
            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;

             if (cboExecute.Text == "Delete")
            {
                try
                {
                    cmd.CommandText = @"delete from mtusers where username = @username";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value =txtList.Text;
                    int kq = cmd.ExecuteNonQuery();

                    MessageBox.Show("Xoa thành công");
                    DisplayData();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }

    }
}

