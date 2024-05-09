using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public class Customer : User
    {

        public string PhoneNumber { get; set; }
        public string? Adress { get; set; }

        public Customer(int id, string firstName, string lastName, string email, string password, string? adress, string phoneNumber)
            : base(id, firstName, lastName, email, password)
        {
            PhoneNumber = phoneNumber;
            Adress = adress;

        }

        public Customer()
        {

        }

    }
}
