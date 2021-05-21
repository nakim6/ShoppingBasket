using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class BasketItem
    {
        Product item;
        public Product Item {
            get {return item; }
            set {item = value; } 
        }
        
        int quantity;
        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public BasketItem(Product product, int quantity)
        {
            this.item = product;
            this.quantity = quantity;
        }
                
    }
}
