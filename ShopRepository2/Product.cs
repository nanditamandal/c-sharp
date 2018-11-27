using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository2
{
    public class Product
    {
        private string product_ID;
        private string product_Name;
        private double product_Price;
        private double quantity;

        public string Product_ID
        {
            get { return product_ID; }
            set { product_ID = value; }
        }

        public string Product_Name
        {
            get { return product_Name; }
            set { product_Name = value; }
        }

        public double Product_Price
        {
            get { return product_Price; }
            set { product_Price = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

       
    }
}
