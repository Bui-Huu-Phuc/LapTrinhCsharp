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
using System.Data.OleDb;
using System.IO;
using System.Configuration;

namespace DemoProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        //string serverName = "", databaseName = "", userName = "", passWord = "";

        //public void readConnectString(string dirStr)
        //{
        //    StreamReader reader = null;
        //    reader = File.OpenText(dirStr);
        //    string line = "";
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        switch (line.Substring(0, line.IndexOf("")))
        //        {
        //            case "servername":
        //                serverName = line.Substring(line.IndexOf("=") + 1, line.Length - line.IndexOf("=") - 1);
        //                break;
        //            case "database":
        //                databaseName = line.Substring(line.IndexOf("=") + 1, line.Length - line.IndexOf("=") - 1);
        //                break;
        //            case "username":
        //                userName = line.Substring(line.IndexOf("=") + 1, line.Length - line.IndexOf("=") - 1);
        //                break;
        //            case "password":
        //                passWord = line.Substring(line.IndexOf("=") + 1, line.Length - line.IndexOf("=") - 1);
        //                break;
        //        }
        //    }
        //}
        //Show employee
        private void btnEmployee_Click(object sender, EventArgs e)
        {

            string str = @"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True";
            SqlConnection Connect = null;
            try
            {
                //readConnectString("Connect.txt");
                
                //string ConnectString = "Data Source=" + serverName + "; Database=" + databaseName + "; User ID=" + userName + ";Password=" + passWord; 

                Connect = new SqlConnection(str);
                Connect.Open();

                MessageBox.Show("Connect successful!", "(☞ﾟヮﾟ)☞");
                employee emp = new employee();
                emp.ShowDialog();

             
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message,"༼ つ ◕_◕ ༽つ");
            }
            finally
            {
                Connect.Close();
            }
        }

        //Exit
        private void button5_Click(object sender, EventArgs e)
        {         
                DialogResult yesno = MessageBox.Show("Sign out?", "(☞ﾟヮﾟ)☞", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                {
                    this.Visible = false;
                    formLogin log = new formLogin();
                    log.ShowDialog();
                }
        }


 
    }
}
