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
using ShopRepository2;

namespace ShopApplication
{
    public partial class Admin_login : Form
    {
        SqlConnection con = new SqlConnection();  

        public Admin_login()
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\microprocessor\project\ShopManagement\CSharp.mdf;Integrated Security=True;Connect Timeout=30";
            InitializeComponent();
        }

        private void LoginRegBtn_Click(object sender, EventArgs e)
        {
            reg r = new reg();
            r.Show();
            this.Hide();
        }

        private void LoginLoginBtn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            a.Admin_Name = LoginUserTBox.Text;
            a.Admin_Password = LoginPassTBox.Text;

            AdminRepository arepo = new AdminRepository();

            if (arepo.AdminLogin(a))
            {
                Salesman_Information si = new Salesman_Information();
                si.Show();
                this.Hide();


            }

            else { MessageBox.Show("Invalid name or password", "login"); }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginCusRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectMain_Form pjf = new ProjectMain_Form();
            pjf.Show();
            this.Hide();
        }
    }
}
