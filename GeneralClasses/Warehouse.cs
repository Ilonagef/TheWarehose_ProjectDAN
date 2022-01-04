using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Warehouse
    {
        private List<Product> ItemList { get; }
        private int MaximumStorageCapacity { get; }

        public Warehouse(int maximumStorageCapacity)
        {
            this.MaximumStorageCapacity = maximumStorageCapacity;
            this.ItemList = new List<Product>(maximumStorageCapacity);
        }

        public int GetCorrentCapacity()
        {
            return this.ItemList.Count;
        }

        public Product FetchProduct(Product p)
        {
            if (ItemList.Contains(p))
            {
                return ItemList[ItemList.IndexOf(p)];
            }
            else
            {
                return null;
            }
        }

        public void InformationToSupplier()
        {

        }

        public void AutoOrder()
        {

        }

        //public void AddItem(Product product)
        //{
        //    try
        //    {
        //        this.ItemList.Add(product);
        //    }
        //   // catch(Exception e)
        //    {
        //        //צריך להודיע למשתמש שהמחסן מלא
        //    }
        //}

    }
}
