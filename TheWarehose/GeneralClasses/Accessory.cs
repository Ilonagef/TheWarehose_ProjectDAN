using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Warehouse
{
    public class Accessory : Product
    {
        public float Size { get; set; }
        public string Material { get; set; }

        public Accessory(int productID, string name, string description, float price, string manufacture, float size) : base(productID, name, description, price, manufacture)
        {
            this.Size = size;

        }
    }
}
