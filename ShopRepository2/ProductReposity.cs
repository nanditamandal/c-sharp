using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopRepository2
{
    public class ProductRepository : IProductRepository
    {
        public bool Insert(Product p)
        {
            try
            {
                string query = "INSERT into Product VALUES ('" + p.Product_ID + "', '" + p.Product_Name + "', " + p.Product_Price + ", " + p.Quantity + ")";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            ///update


        }
        public bool Update(Product p)
        {
            try
            {
                string query = "UPDATE Product SET Product_Name='" + p.Product_Name + "', Product_Price = " + p.Product_Price + ", Quantity= " + p.Quantity + " WHERE Product_ID = '" +p.Product_ID + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }

       //delete

        public bool Delete(Product p)
        {
            try
            {
                string query = "DELETE From Product WHERE Product_ID='" +p.Product_ID+ "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
       

        public List<Product> GetAllProduct()
        {
            string query = "SELECT * from Product";
            List<Product> pList = new List<Product>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Product p = new Product();
                p.Product_ID = sdr["Product_ID"].ToString();
                p.Product_Name = sdr["Product_Name"].ToString();
                p.Product_Price =Convert.ToDouble (sdr["Product_Price"]);
                p.Quantity = Convert.ToDouble(sdr["Quantity"]);

                pList.Add(p);
            }
            dcc.CloseConnection();
            return pList;
        }

        public List<Product> Buyallproduct()
        {
            string query = "SELECT * from Pamentslip";
            List<Product> pList = new List<Product>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Product p = new Product();
                p.Product_ID = sdr["Product_ID"].ToString();
                p.Product_Name = sdr["Product_Name"].ToString();
                p.Product_Price = Convert.ToDouble(sdr["Product_Price"]);
                p.Quantity = Convert.ToDouble(sdr["Quantity"]);

                pList.Add(p);
            }
            dcc.CloseConnection();
            return pList;
        }

        public List<Product> Search(Product p)
        {
            
            

                string query = "SELECT * from Product WHERE Product_ID = '" + p.Product_ID + "'";
                List<Product> pList = new List<Product>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Product pro = new Product();
                pro.Product_ID = sdr["Product_ID"].ToString();
                pro.Product_Name = sdr["Product_Name"].ToString();
                pro.Product_Price =Convert.ToDouble (sdr["Product_Price"]);
                pro.Quantity = Convert.ToDouble(sdr["Quantity"]);

                pList.Add(pro);
            }
            dcc.CloseConnection();
            return pList;

        }


        public bool buyproduct(Product p)
        {
            try
            {
                string query =  "UPDATE Product SET Product_Name='" + p.Product_Name + "', Product_Price = " + p.Product_Price + ", Quantity= Quantity-" + p.Quantity + " WHERE Product_ID = '" +p.Product_ID + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool pamentslip(Product p)
        {
            try
            {
                string query = "INSERT into Pamentslip VALUES ('" + p.Product_ID + "', '" + p.Product_Name + "', " + p.Product_Price + ", " + p.Quantity + ")";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
      //  public string Product_ID { get; set; }

        public List<Product> Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> pList { get; set; }

        public void Get(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> search()
        {
            throw new NotImplementedException();
        }

        public List<Product> Search()
        {
            throw new NotImplementedException();
        }
    }
}
