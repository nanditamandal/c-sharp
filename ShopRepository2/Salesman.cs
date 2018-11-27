using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public class Salesman
    {
        private string salesman_Name;
        private string salesman_Mobile;
        private string salesman_Address;
        private string salesman_Password;
        private string salesman_ID;

        public string Salesman_Name
        {
            get { return salesman_Name; }
            set { salesman_Name = value; }
        }

        public string Salesman_ID
        {
            get { return salesman_ID; }
            set { salesman_ID = value; }
        }

        public string Salesman_Mobile
        {
            get { return salesman_Mobile; }
            set { salesman_Mobile = value; }
        }

        public string Salesman_Address
        {
            get { return salesman_Address; }
            set { salesman_Address = value; }
        }

        public string Salesman_Password
        {
            get { return salesman_Password; }
            set { salesman_Password = value; }
        }

      
    }
}
