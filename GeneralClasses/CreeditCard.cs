using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class CreeditCard : PaymentMethod
    {
        public string CreeditCardCompany { get; set; }
        public string CreeditCardNumber { get; set; }
        public string CreeditCardValidity { get; set; }
        public string CreeditCardBackNumber { get; set; }

        public CreeditCard(string shipmentAdress, string phoneNumber,string creeditCardCompany, string creeditCardNumber, string creeditCardValidity, string creeditCardBackNumber):base(shipmentAdress, phoneNumber)
        {
            this.CreeditCardCompany = creeditCardCompany;
            this.CreeditCardNumber = creeditCardNumber;
            this.CreeditCardValidity = creeditCardValidity;
            this.CreeditCardBackNumber = creeditCardBackNumber;
        }

      


    }
}
