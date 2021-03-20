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
using System.Xml;

namespace DemoProject
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                DialogResult yesno = MessageBox.Show("Are you sure?", "(☞ﾟヮﾟ)☞", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        string str = @"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection Connect = null;
        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
        {
            Connect = new SqlConnection(str);
            Connect.Open();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;//Ket noi
           
           //search
            cmd.CommandText = @"Select fullname From MTUsers where username like @username";//parameter
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtSearch.Text;
            cmd.ExecuteNonQuery();
            object kq = cmd.ExecuteScalar();
            if (kq == null)
            {
                txtShow.Text = "404 Not Found";
            }
            else
            {
                txtShow.Text = kq.ToString();
            }

            ////reader
            //cmd.CommandText = @"Select username From MTUsers ";//parameter
            //cmd.CommandType = CommandType.Text;
            //SqlDataReader reader = cmd.ExecuteReader();

            //string kq = "";
            //while (reader.Read())
            //{
            //    kq = kq + reader[0].ToString() + ", ";
            //}
            //txtShow.Text = kq;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;//Ket noi

            //cmd.CommandText = @"Select fullname From MTUsers where username like '%" + txtSearch.Text + "%'";//Cau lenh truy xuat SQL
            cmd.CommandText = @"delete From MTUsers where username like @username ";//parameter
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtSearch.Text;
            int kq = cmd.ExecuteNonQuery();
            if (kq == 0)
            {
                txtShow.Text = "x";
            }
            else
            {
                txtShow.Text = "✔";
            }
        }

        private void lblList_Click(object sender, EventArgs e)
        {
            Connect = new SqlConnection(str);
            Connect.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;//Ket noi


            //reader
            cmd.CommandText = @"Select * From MTUsers 
                                FOR XML AUTO,elements";
            //cmd.CommandType = CommandType.Text;
            XmlReader reader = cmd.ExecuteXmlReader();
            string kq = "";

            while (!reader.EOF)
            {
                kq += reader.ReadOuterXml() + ", ";
            };
            reader.Close();
            txtShow.Text = kq;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdateUser fr2 = new UpdateUser();
            fr2.ShowDialog();
           
        }
    }
}
