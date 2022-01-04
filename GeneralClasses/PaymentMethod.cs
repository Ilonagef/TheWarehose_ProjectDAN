using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class PaymentMethod
    {
       

        public string ShipmentAdress { get; set; }
        public string PhoneNumber { get; set; }

         public PaymentMethod(string shipmentAdress, string phoneNumber)
        {
            this.ShipmentAdress = shipmentAdress;
            this.PhoneNumber = phoneNumber;
        }

    }
}
