using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasketClasses
{
    public class Basket
    {
        public List<BasketItem> items;

        public Basket()
        {
            items = new List<BasketItem>();
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
                Console.WriteLine("Product name: " + bi.Item.ProductName + ", Product price: " + bi.Item.Price.ToString() + "$, Quantity: " + bi.Quantity.ToString());
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
            Console.WriteLine("Log Start.");
            // Log all items in the basket
            ListBasketItems();

            decimal totalPrice = 0;

            foreach (BasketItem bi in items)
            {
                totalPrice+=(bi.Item.Price*bi.Quantity);
            }

            totalPrice-= Discount.CalculateDiscount(this);
            Console.WriteLine("Total price: " + totalPrice.ToString());
            Console.WriteLine("Log end.");
            Console.WriteLine();
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
