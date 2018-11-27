using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public class Customer
    {
        private string customer_Name;
        private string customer_Mobile;
        private string customer_Address;
        private double customer_Password;
        private string customer_ID;

        public string Customer_Name
        {
            get { return customer_Name; }
            set { customer_Name = value; }
        }

        public string Customer_Mobile
        {
            get { return customer_Mobile; }
            set { customer_Mobile = value; }
        }

        public string Customer_Address
        {
            get { return customer_Address; }
            set { customer_Address = value; }
        }

        public double Customer_Pass
        {
            get { return customer_Password; }
            set { customer_Password = value; }
        }

        public string Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        public string Customer_Password { get; set; }
    }
}
