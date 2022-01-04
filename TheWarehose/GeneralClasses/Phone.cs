using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Phone : Product
    {
        public int RAMamount { get; set; }
        public int Storage { get; set; }
        public float BatteryCapacity { get; set; }
        public float ScreenSize { get; set; }

        public Phone(int productID, string name, string description, float price, string manufacture, int RamAmount, int storage, float batteycapcity, float screensize) : base(productID, name, description, price, manufacture)
        {
            this.ProductID = productID;
            this.RAMamount = RamAmount;
            this.Storage = storage;
            this.BatteryCapacity = batteycapcity;
            this.ScreenSize = screensize;
        }


    }
}
