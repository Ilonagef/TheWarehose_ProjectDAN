using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Warehouse

{
    public abstract class Person
    {
        protected string EmailAdress { get; set; }
        protected string FullName { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Residence { get; set; }

        public Person(string email, string name,string phoneNumber,string residence)
        {
            this.EmailAdress = email;
            this.FullName = name;
            this.PhoneNumber = phoneNumber;
            this.Residence = residence;
        }
    }


}
