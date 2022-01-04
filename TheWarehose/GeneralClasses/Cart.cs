using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Cart
    {
        public List<Product> ProductList { get; set; }
        public PaymentMethod CartPayment { get; set; }

        public Cart()
        {
            this.ProductList = new List<Product>();
            this.CartPayment = new PaymentMethod(null,null);
        }

        public void ProductDuplication(int amount,Product product)
        {
            for(int i = 0; i < amount; i++) 
            {
                this.ProductList.Add(product); 
            }
        }

        public double CalculateCartTotalPrice()
        {
            double CartPrice = 0;

            foreach (Product p in this.ProductList)
            {
                    CartPrice += p.Price;
            }

            return CartPrice;           
        }

        public void GoToCheckOut()
        {

        }
    }
}
