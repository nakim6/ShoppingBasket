using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingBasketClasses;


namespace ShopingBasketTest
{
    [TestClass]
    public class UnitTest_ShoppingBasket
    {
        Basket basket = new Basket();

        Product butter = new Product("Butter", 0.80m);
        Product bread = new Product("Bread", 1.00m);
        Product milk = new Product("Milk", 1.15m);

        [TestMethod]
        public void Scenario1()
        {
            basket.AddProductInBasket(butter, 1);
            basket.AddProductInBasket(bread, 1);
            basket.AddProductInBasket(milk, 1);

            decimal totalPrice = basket.TotalPrice();

            Assert.AreEqual(2.95m, totalPrice);
        }

        [TestMethod]
        public void Scenario2()
        {
            basket.AddProductInBasket(butter, 2);
            basket.AddProductInBasket(bread, 2);
            
            decimal totalPrice = basket.TotalPrice();

            Assert.AreEqual(3.10m, totalPrice);
        }

        [TestMethod]
        public void Scenario3()
        {
            basket.AddProductInBasket(milk, 4);

            decimal totalPrice = basket.TotalPrice();

            Assert.AreEqual(3.45m, totalPrice);
        }

        [TestMethod]
        public void Scenario4()
        {
            basket.AddProductInBasket(butter, 2);
            basket.AddProductInBasket(bread, 1);
            basket.AddProductInBasket(milk, 8);

            decimal totalPrice = basket.TotalPrice();

            Assert.AreEqual(9.00m, totalPrice);
        }
    }
}
