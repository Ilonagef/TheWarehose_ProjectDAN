using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse/// change it project namespace
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderStatus { get; set; }
        public List<Product> OrderProductList { get; set; }

        public Order(int orderID, int orderStatus,List<Product> productList)
        {
            this.OrderID = orderID;
            this.OrderStatus = orderStatus;
            this.OrderProductList = productList;
            
        }


        public void ShowTrackingDetails()
        {

        }
        public void ViewOrder()
        {

        }
    }
}
