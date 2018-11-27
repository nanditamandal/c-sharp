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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void RegBackBtn_Click(object sender, EventArgs e)
        {
            Admin_login f = new Admin_login();
            f.Show();
            this.Hide();
        }

        private void RegAddBtn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Admin_Name = nametextbox.Text;
            a.Admin_ID= idtextbox.Text;
            a.Admin_Password=passwordtextbox.Text;
            a.Admin_Mobile= mobiletextbox.Text;
            a.Admin_Address = addresstextbox.Text;

            AdminRepository adminrepo = new AdminRepository();
            if(adminrepo.Insert( a))

            { 
                MessageBox.Show(" Admin Registration complete", "Admin");

            }
            else
            {
                MessageBox.Show("Admin Registration incomplete", "Admin");
            }
           
          
            
            


            
        }
            
              
           
           
           
          /*  if(i>0)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("There is some problem");
            }*/

       /*     t.Show();
            this.Hide();
            * */

        

        private void RegPassTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
