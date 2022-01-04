using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Employee : User
    {
        public Employee(string pass, string userName, string email, string name, string phoneNumber, string residence, bool Ismanager) : base(pass, userName, email, name, phoneNumber, residence, Ismanager)
        {

        }

        public void MakeOrder()
        {

        }

        public void RemoveProduct(Product product)
        {

        }

        public void AskTheSupplier(Suplier suplier, string question)
        {

        }

    }


}
