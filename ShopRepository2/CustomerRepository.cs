using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace ShopRepository2
{
    public class CustomerRepository : ICustomerRepository
    {
        Product p = new Product();

        public bool Insert(Customer c)
        {
            try
            {
                string query = "INSERT into Customer VALUES ('" + c.Customer_ID + "', '" + c.Customer_Name + "', '" + c.Customer_Password + "', '" + c.Customer_Address + "', '" + c.Customer_Mobile + "')";
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
             public bool CustomerLogin(Customer c)
        {
            string query = "SELECT * from Customer WHERE Customer_Name = '" + c.Customer_Name+ "' AND Customer_Password='" + c.Customer_Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr.Read())
            {
                c.Customer_ID = sdr["Customer_ID"].ToString();
                c.Customer_Mobile = sdr["Customer_Mobile"].ToString();
                c.Customer_Address = sdr["Customer_Address"].ToString();
                dcc.CloseConnection();
                return true;



            }


            else
            {
                dcc.CloseConnection();
                return false;
            }
        }
            
        }
    }


