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
    public partial class SalesmanLogin : Form
    {
        public SalesmanLogin()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ProjectMain_Form pjf = new ProjectMain_Form();
            pjf.Show();
            this.Hide();
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Salesman s = new Salesman();
            s.Salesman_ID = nametextbos.Text;
            s.Salesman_Password = passwordtextbox.Text;

            SalesmanRepository salerepo= new SalesmanRepository();

            if (salerepo.salesmanLogin(s))
            {
                product_detail pd = new product_detail();
                pd.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid name or password", "login");
            }

        }
    }
}
