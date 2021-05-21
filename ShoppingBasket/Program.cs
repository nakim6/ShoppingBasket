using System;

namespace ShoppingBasket
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            
            Product butter = new Product("Butter", 0.80m);
            Product bread = new Product("Bread", 1.00m);
            Product milk = new Product("Milk", 1.15m);


            basket.AddProductInBasket(butter, 1);
            basket.AddProductInBasket(bread,1);
            basket.AddProductInBasket(milk, 1);

            basket.ListBasketItems();

            Console.WriteLine("Total price: " + basket.TotalPrice().ToString() + " - Discount: " + Discount.CalculateDiscount(basket).ToString() + " - Final price: " + (basket.TotalPrice() - Discount.CalculateDiscount(basket)).ToString()) ;            
        }
    }
}
