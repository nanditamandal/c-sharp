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
    public partial class Customer_Registration : Form
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(); ;
            c.Customer_ID = idtextBox1.Text;
            c.Customer_Name = nametextBox2.Text;
            c.Customer_Password = passwordtextBox3.Text;
            c.Customer_Address = addresstextBox4.Text;
            c.Customer_Mobile = mobiletextBox5.Text;

            CustomerRepository customerrepo = new CustomerRepository();
            if (customerrepo.Insert(c))
            {
                MessageBox.Show(" Admin Registration complete", "Admin");

            }
            else
            {
                MessageBox.Show("Admin Registration incomplete", "Admin");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }
    }
}
