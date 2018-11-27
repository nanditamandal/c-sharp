using ShopRepository2;
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
    public partial class product_detail : Form
    {
        public product_detail()
        {
            InitializeComponent();
        }

        private void AddProAddBtn_Click(object sender, EventArgs e)
        {

            Product p = new Product();

            p.Product_ID = this.AddProIDTBox.Text;
            p.Product_Name = this.AddProNameTBox.Text;

            p.Product_Price = Convert.ToDouble(this.AddProPriTBox.Text);
            p.Quantity = Convert.ToDouble(this.AddProQuaTBox.Text);

            ProductRepository ProRepo = new ProductRepository();
            if (ProRepo.Insert(p))
            {
                MessageBox.Show(" Insert product", "Insert Error");

                List<Product> ProList = ProRepo.GetAllProduct();
                this.dataGridView1.DataSource = ProList;
            }
            else
            {
                MessageBox.Show("Can Not Insert product", "Insert Error");
            }
        }

        private double Convret(string p)
        {
            throw new NotImplementedException();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            Product p = new Product();

           
            p.Product_ID = this.AddProIDTBox.Text;
            p.Product_Name = this.AddProNameTBox.Text;

            p.Product_Price = Convert.ToDouble(this.AddProPriTBox.Text);
            p.Quantity = Convert.ToDouble(this.AddProQuaTBox.Text);
           

            ProductRepository ProRepo = new ProductRepository();
            if (ProRepo.Delete(p))
            {
                MessageBox.Show("delete", "Insert Error");

                
            }
            else
            {
                MessageBox.Show("Can Not Insert product", "Insert Error");
            }
            
        }

        private void Load_Click(object sender, EventArgs e)
        {
            ProductRepository ProRepo = new ProductRepository();
            Product p = new Product();
            List<Product> ProList = ProRepo.GetAllProduct();
            this.dataGridView1.DataSource = ProList;

        }


        public string Product_ID { get; set; }

        private void update_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            p.Product_ID = this.AddProIDTBox.Text;
            p.Product_Name = this.AddProNameTBox.Text;

            p.Product_Price = Convert.ToDouble(this.AddProPriTBox.Text);
            p.Quantity = Convert.ToDouble(this.AddProQuaTBox.Text);

            ProductRepository ProRepo = new ProductRepository();
            if (ProRepo.Update(p))
            {
                MessageBox.Show("Update product", "Insert Error");
                
                
            }
            else
            {
                MessageBox.Show("Can Not update product", "Insert Error");
            }
        }

        private void Load_Click()
        {
            throw new NotImplementedException();
        }
         
        private void search_Click(object sender, EventArgs e)
        {

            ProductRepository ProRepo = new ProductRepository();
            Product p = new Product();
            p.Product_ID = textBox1.Text;
            List<Product> ProList = ProRepo.Search(p);
            this.dataGridView1.DataSource = ProList;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            SalesmanLogin sl = new SalesmanLogin();
            sl.Show();
            this.Hide();
        }
    }

      
    }

