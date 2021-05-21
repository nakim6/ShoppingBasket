using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasketClasses
{
    public class Product
    {
        string productName;
        public string ProductName {
            get { return productName; }   
            set { productName = value; }
        }

        
        decimal price;
        public decimal Price{
            get { return price; }
            set { price = value; }
        }

        public Product(string name, decimal price)
        {
            this.productName = name;
            this.price = price;            
        }

    }
}
