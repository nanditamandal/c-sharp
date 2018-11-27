using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public class Admin
    {
        private string admin_Name;
        private string admin_Mobile;
        private string admin_ID;
        private string admin_password;
        private string admin_address;

        public string Admin_Address
        {
            get { return admin_address; }
            set { admin_address = value; }
        }

        public string Admin_Name
        {
            get { return admin_Name; }
            set { admin_Name = value; }
        }

        public string Admin_Mobile
        {
            get { return admin_Mobile; }
            set { admin_Mobile = value; }
        }

        public string Admin_ID
        {
            get { return admin_ID; }
            set { admin_ID = value; }
        }

        public string Admin_Password
        {
            get { return admin_password; }
            set { admin_password = value; }
        }
    }
}
