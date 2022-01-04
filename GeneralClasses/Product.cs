using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public abstract class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Manufacture { get; set; }


        public Product(int productID, string name, string description, float price, string manufacture)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Manufacture = manufacture;
        }

        public Product(Product p)
        {
            this.ProductID = p.ProductID;
            this.Name = p.Name;
            this.Description = p.Description;
            this.Price = p.Price;
            this.Manufacture = p.Manufacture;

        }

        public string ProductDetails()
        {
            return
                "Product ID : " + this.ProductID + ".\n" +
                "Product name : " + this.Name + ".\n" +
                "Product description : " + this.Description + ".\n" +
                "Product price : " + this.Price + ".\n" +
                "Product manufacture : " + this.Manufacture + ".\n";
        }
    }

}
