# ShoppingBasket - C# Solution

## ShoppingBasket solution consists of two projects: ShoppingBasketClasses and ShopingBasketTests.

#### ShoppingBasketClasses project implements shoping basket functionalities using four classes: Product, BasketItem, Basket and Discount.

* Class Basket is main class Basket with only one property (list of BasketItems objects) and five methodes (AddProductInBasket, CountProducts, GetPrice, TotalPrice and LogAllBasketItems).   
* Class BasketItem has two properites Product and Quantity. Constructor creates new instance of object with given product and quantity. 
* Class Product has two properties productName and price. Constructor creates new instance of object with given name and price. 
* Class Discount is singleton and has only method CalculateDiscount which calculate discount for given Basket object. 
  
  
#### ShoppingBasketTests project implements testing methodes for testing ShoppingBasketClasses.
