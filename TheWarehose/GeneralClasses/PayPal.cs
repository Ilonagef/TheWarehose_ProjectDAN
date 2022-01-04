using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class PayPal : PaymentMethod
    {
        public string PayPalAccount { get; set; }

        public PayPal(string shipmentAdress, string phoneNumber, string payPalAccount): base(shipmentAdress, phoneNumber)
        {
            PayPalAccount = payPalAccount;
        }


    }
}
