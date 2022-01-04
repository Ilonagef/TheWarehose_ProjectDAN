using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Warehouse
{
    public class Shipment
    {
        private List<Product> ShipmentProduct { get; set; }
        private Date AssessmentShipmentDate { get; set; }
        private double ShipmentPrice { get; }
        private string ShipmentAddress { get; set; }

        public Shipment(List<Product> productList,Date date,string address)
        {
            ShipmentProduct = productList;
            this.AssessmentShipmentDate = date;
            this.ShipmentAddress = address;
            this.ShipmentPrice = this.CalcShipmentPrice();
        }

        private double CalcShipmentPrice()
        {
            double shipmentPrice = 0;

            foreach(Product p in this.ShipmentProduct)
            {
                shipmentPrice += p.Price;
            }

            return shipmentPrice;
        }

        public void ViewShipment()
        {

        }




    }
}
