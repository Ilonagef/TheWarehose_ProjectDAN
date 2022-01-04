using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public abstract class User : Person
    {
        protected bool IsManager { get; set; }
        protected string Password { get; set; }
        protected string UserName { get; set; }

        public User(string pass, string userName, string email, string name, string phoneNumber, string residence, bool Ismanager ) : base(email, name, phoneNumber, residence)
        {
            this.IsManager = Ismanager;            
            this.Password = pass;
            this.UserName = userName;
        }
    }
}
