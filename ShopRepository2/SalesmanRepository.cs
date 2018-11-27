using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopRepository2
{
    public class SalesmanRepository : ISalesmanRepository
    {
        public bool Insert(Salesman s)
        {
            try
            {
                string query = "INSERT into Salesman VALUES ('" + s.Salesman_ID + "', '" + s.Salesman_Name + "', '" + s.Salesman_Password + "', '"+ s.Salesman_Address + "', '" + s.Salesman_Mobile + "')";
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
        public bool Update(Salesman s)
        {
            try
            {
                string query = "UPDATE Salesman SET Salesman_Name='" + s.Salesman_Name + "', Salesman_Mobile = '" + s.Salesman_Mobile + "', Salesman_Address=' " + s.Salesman_Address + "', Salesman_Password = '" + s.Salesman_Password + "' WHERE Salesman_ID = '" + s.Salesman_ID + "'";
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

        public bool Delete(Salesman s)
        {
            try
            {
                string query = "DELETE From Salesman WHERE Salesman_ID='" + s.Salesman_ID + "'";
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


        public List<Salesman> GetAllSalesman()
        {
            string query = "SELECT * from Salesman";
            List<Salesman> sList = new List<Salesman>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Salesman s = new Salesman();
                s.Salesman_ID = sdr["Salesman_ID"].ToString();
                s.Salesman_Name = sdr["Salesman_Name"].ToString();
                s.Salesman_Mobile = sdr["Salesman_Mobile"].ToString();
                s.Salesman_Address = sdr["Salesman_Address"].ToString();
                s.Salesman_Password = sdr["Salesman_Password"].ToString();

                sList.Add(s);
            }
            dcc.CloseConnection();
            return sList;
        }

        public List<Salesman> Search(Salesman s)
        {



            string query = "SELECT * from Salesman WHERE Salesman_ID = '" + s.Salesman_ID + "'";
            List<Salesman> sList = new List<Salesman>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Salesman sm = new Salesman();
                sm.Salesman_ID = sdr["Salesman_ID"].ToString();
                sm.Salesman_Name = sdr["Salesman_Name"].ToString();
                sm.Salesman_Mobile = sdr["Salesman_Mobile"].ToString();
                sm.Salesman_Address = sdr["Salesman_Address"].ToString();
                sm.Salesman_Password = sdr["Salesman_Password"].ToString();

                sList.Add(sm);
            }
            dcc.CloseConnection();
            return sList;

        }

        public bool salesmanLogin(Salesman s)
        {
            string query = "SELECT * from Salesman WHERE Salesman_ID = '" + s.Salesman_ID + "' AND Salesman_Password='" + s.Salesman_Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr.Read())
            {
                s.Salesman_Name = sdr["Salesman_Name"].ToString();
                s.Salesman_Mobile = sdr["Salesman_Mobile"].ToString();
                s.Salesman_Address = sdr["Salesman_Address"].ToString();
                dcc.CloseConnection();
                return true;



            }


            else
            {
                dcc.CloseConnection();
                return false;
            }
        }

       

        public List<Salesman> Get()
        {
            throw new NotImplementedException();
        }

        public string Salesman_ID { get; set; }
    }
}


