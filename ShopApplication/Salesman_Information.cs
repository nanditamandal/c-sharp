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
    public partial class Salesman_Information : Form
    {
        public Salesman_Information()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void AdminAddBtn_Click(object sender, EventArgs e)
        {
            Salesman s = new Salesman();
            s.Salesman_ID = this.IDtextBox3.Text;
            s.Salesman_Name = this.NametextBox1.Text;
            s.Salesman_Mobile = this.MobiletextBox6.Text;
            s.Salesman_Address = this.AddresstextBox5.Text;
            s.Salesman_Password =this.PasswordtextBox4.Text;

            SalesmanRepository salemanRepo = new SalesmanRepository();
            if (salemanRepo.Insert(s))
            {
                MessageBox.Show("Insert salesman", "Insert Error");
                List<Salesman> sList = salemanRepo.GetAllSalesman();
                this.dataGridView1.DataSource = sList;
            }
            else
            {
                MessageBox.Show("Can Not Insert salesman", "Insert Error");
            }
         

        }

        private void AdminUpdateBtn_Click(object sender, EventArgs e)
        {
            Salesman s = new Salesman();
            s.Salesman_ID = this.IDtextBox3.Text;
            s.Salesman_Name = this.NametextBox1.Text;
            s.Salesman_Mobile = this.MobiletextBox6.Text;
            s.Salesman_Address = this.AddresstextBox5.Text;
            s.Salesman_Password = this.PasswordtextBox4.Text;

            SalesmanRepository salemanRepo = new SalesmanRepository();
            if (salemanRepo.Update(s))
            {
                MessageBox.Show("Update salesman", "Update Error");

            }
            else
            {
                MessageBox.Show("Can Not update salesman", "Update Error");
            }
        }

        private void AdminDelBtn_Click(object sender, EventArgs e)
        {
            Salesman s = new Salesman();
            s.Salesman_ID = this.IDtextBox3.Text;
            s.Salesman_Name = this.NametextBox1.Text;
            s.Salesman_Mobile = this.MobiletextBox6.Text;
            s.Salesman_Address = this.AddresstextBox5.Text;
            s.Salesman_Password = this.PasswordtextBox4.Text;

            SalesmanRepository salemanRepo = new SalesmanRepository();
            if (salemanRepo.Delete(s))
            {
                MessageBox.Show("Delete salesman", "delete Error");

            }
            else
            {
                MessageBox.Show("Can Not Delete salesman", "Delete Error");
            }
        }

        private void AdminBackBtn_Click(object sender, EventArgs e)
        {
            Admin_login g = new Admin_login();
            g.Show();
            this.Hide();

        }

        private void AdminCheckBtn_Click(object sender, EventArgs e)
        {
            SalesmanRepository salemanRepo = new SalesmanRepository();
            Salesman s = new Salesman();
            List<Salesman> salemanList = salemanRepo.GetAllSalesman();
            this.dataGridView1.DataSource = salemanList;
        }

        private void AdminSalesLab_Click(object sender, EventArgs e)
        {

        }

        private void NametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            SalesmanRepository salemanRepo = new SalesmanRepository();
            Salesman s = new Salesman();
            s.Salesman_ID = textBox1.Text;
            List<Salesman> salemanList = salemanRepo.Search(s);
            this.dataGridView1.DataSource = salemanList;
        }
    }
}
