using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Discount
    {
        public static decimal CalculateDiscount(Basket basket)
        {
            decimal discount=0;

            // 50% of one bread price if zou buy two butters
            int noOfSecondButter = basket.CountProducts("Butter") / 2;
            if (noOfSecondButter > basket.CountProducts("Bread")) discount += basket.GetPrice("Bread") * noOfSecondButter/ 2;
            else if (noOfSecondButter>0) discount += basket.GetPrice("Bread") / 2;
            Console.WriteLine(noOfSecondButter.ToString());

            // Every forth milk is free
            int noOfThirdMilk = basket.CountProducts("Milk") / 3;
            int noOfForthMilk = basket.CountProducts("Milk") / 4;
            discount += noOfForthMilk * basket.GetPrice("Milk");      

            return discount;
        }
    }
}
