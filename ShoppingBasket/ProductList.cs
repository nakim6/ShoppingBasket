using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class ProductList
    {
        List<Product> Products;

        public ProductList()
        {
            this.Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public decimal GetPrice(string productName)
        {
            decimal price = 0;
            foreach (Product product in Products)
            {
                if (product.ProductName == productName) price=product.Price;                   
            }
            return price;
        }
    }

    
}
