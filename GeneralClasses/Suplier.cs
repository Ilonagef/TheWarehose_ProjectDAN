using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Suplier : Person
    {
        private List<Shipment> SupplierShipment { get; set; }


        public Suplier(string email, string name, string phoneNumber, string residence) : base(email, name, phoneNumber, residence)
        {
            this.SupplierShipment = new List<Shipment>();
        }

        public void SendShipment()
        {

        }

        public void CancelShipment(Shipment shipment)
        {
            this.SupplierShipment.Remove(shipment);
        }

        public void AddShipment(Shipment shipment)
        {
            this.SupplierShipment.Add(shipment);
        }

        public void GetOrderFromEmployee()
        {

        }

        public void AnswerTheEmployee()
        {

        }
    }
}
