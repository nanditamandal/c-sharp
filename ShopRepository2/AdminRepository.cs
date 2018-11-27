using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopRepository2
{
    public class AdminRepository : IAdminRepository
    {
        public bool Insert(Admin a)
        {
            try
            {
                string query = "INSERT into Admin VALUES ('" + a.Admin_Name + "', '" + a.Admin_ID + "', '" + a.Admin_Password + "', '" + a.Admin_Mobile + "', '" + a.Admin_Address + "')";
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
            public bool AdminLogin(Admin a)
        {
            string query = "SELECT * from Admin WHERE Admin_Name = '" + a.Admin_Name + "' AND Admin_Password='" + a.Admin_Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr.Read())
            {
                a.Admin_ID = sdr["Admin_ID"].ToString();
                a.Admin_Mobile = sdr["Admin_Mobile"].ToString();
                a.Admin_Address = sdr["Admin_Address"].ToString();
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
