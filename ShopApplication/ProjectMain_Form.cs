using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class ProjectMain_Form : Form
    {
        public ProjectMain_Form()
        {
            InitializeComponent();
        }

        private void Adimn_Click(object sender, EventArgs e)
        {
            Admin_login l = new Admin_login();
          //  Adminlogin l = new Adminlogin();
            l.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salesman_Click(object sender, EventArgs e)
        {
            SalesmanLogin sl = new SalesmanLogin();
            sl.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {

            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }
    }
}
