using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasketClasses
{
    public class Discount
    {
        public static decimal CalculateDiscount(Basket basket)
        {
            decimal discount=0;

            // 50% of one bread price if zou buy two butters
            int noOfSecondButter = basket.CountProducts("Butter") / 2;
            if (noOfSecondButter > basket.CountProducts("Bread"))
            {
                discount += basket.GetPrice("Bread") * noOfSecondButter / 2;
                Console.WriteLine("Discount for: " + basket.CountProducts("Butter").ToString() + " butters - " + noOfSecondButter.ToString() + " breads at 50% off.");
            }
            else if (noOfSecondButter > 0)
            {
                discount += basket.GetPrice("Bread") / 2;
                Console.WriteLine("Discount for: " + basket.CountProducts("Butter").ToString() + " butters - " + basket.GetPrice("Bread").ToString() + " breads at 50% off.");
            }

            // Every forth milk is free
            int noOfForthMilk = basket.CountProducts("Milk") / 4;
            discount += noOfForthMilk * basket.GetPrice("Milk");      
            if (noOfForthMilk!=0) Console.WriteLine("Discount for: every forth milk." + noOfForthMilk.ToString() + " milk(s) for fee.");

            return discount;
        }
    }
}
