using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Basket
    {
        public List<BasketItem> items;

        public Basket()
        {
            this.items = new List<BasketItem>();
        }

        public void AddProductInBasket(Product product, int quantity)
        {
            BasketItem tempItem = new BasketItem(product, quantity);
            items.Add(tempItem);
        }

        public void ListBasketItems()
        {
            foreach(BasketItem bi in items)
            {
                Console.WriteLine(bi.Item.ProductName + " - " + bi.Item.Price.ToString() + " x " + bi.Quantity.ToString());
            }
        }

        public decimal GetPrice(string productName)
        {
            decimal price = 0;
            foreach (BasketItem bi in items)
            {
                if (bi.Item.ProductName == productName) price = bi.Item.Price;
            }
            return price;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (BasketItem bi in items)
            {
                totalPrice+=(bi.Item.Price*bi.Quantity);
            }

            return totalPrice;
        }

        public int CountProducts(string productName)
        {
            int count = 0;
            
            foreach (BasketItem bi in items)
            {
                if (bi.Item.ProductName==productName) count+= bi.Quantity;
            }

            return count;
        }
    }
}
