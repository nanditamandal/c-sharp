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
    public partial class Buy_Item : Form
    {
        public Buy_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ProductRepository ProRepo = new ProductRepository();
            Product p = new Product();

            p.Product_ID = textBox1.Text;
            List<Product> ProList = ProRepo.Search(p);
            this.dataGridView1.DataSource = ProList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductRepository ProRepo = new ProductRepository();
            Product p = new Product();
            List<Product> ProList = ProRepo.GetAllProduct();
            this.dataGridView1.DataSource = ProList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            p.Product_ID = this.idtextBox3.Text;
            p.Product_Name = this.nametextBox2.Text;

            p.Product_Price = Convert.ToDouble(this.pricetextBox5.Text);
            p.Quantity = Convert.ToDouble(this.quantitytextbox.Text);

            ProductRepository ProRepo = new ProductRepository();
            if (ProRepo.buyproduct(p))
            {
               
                MessageBox.Show("Update product", "Insert Error");
                ProRepo.pamentslip( p);
                List<Product> ProList = ProRepo.Buyallproduct();
                this.dataGridView2.DataSource = ProList;


            }
            else
            {
                MessageBox.Show("Can Not update product", "Insert Error");
            }
        }

        private void CusBackBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }
    }
}
