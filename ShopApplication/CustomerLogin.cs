using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopRepository2;

namespace ShopApplication
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            Customer_Registration cr = new Customer_Registration();
            cr.Show();
            this.Hide();

        }

        private void lgoinbtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Customer_Name = nametextbtn.Text;
            c.Customer_Password = passwordtextbtn.Text;


            CustomerRepository customerrepo = new CustomerRepository();

            if (customerrepo.CustomerLogin(c))
            {

                Buy_Item bt = new Buy_Item();
                bt.Show();
                this.Hide();


            }

            else { MessageBox.Show("Invalid name or password", "login"); }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ProjectMain_Form pmf = new ProjectMain_Form();
            pmf.Show();
            this.Hide();

        }
    }
}
