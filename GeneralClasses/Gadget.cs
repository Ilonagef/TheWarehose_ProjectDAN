using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Gadget : Product
    {
        public string Port { get; set; }



        public Gadget(int productID, string name, string description, float price, string manufacture, string port) : base(productID, name, description, price, manufacture)
        {
            this.Port = port;
        }
    }
}
