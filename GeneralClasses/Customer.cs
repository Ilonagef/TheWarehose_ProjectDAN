using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Customer:User
    {
        public Cart CustomerCart { get; set; }
        public List<Order> CustomerOrderList { get; set; }

        public Customer(string pass, string userName, string email, string name, string phoneNumber, string residence, bool Ismanager) : base(pass, userName, email, name, phoneNumber, residence, Ismanager)
        {
            this.CustomerCart = new Cart();
            this.CustomerOrderList = new List<Order>();
        }

        public void AddProductToCart(Product product)
        {
            this.CustomerCart.ProductList.Add(product);
        }

        public void RemoveProductFromCart(Product product)
        {
            this.CustomerCart.ProductList.Remove(product);
        }

        public void ViewOrderList()
        {

        }
    }
}
