using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public class Employee : User
    {
        public string? Department { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id,string firstName, string lastName, string email, string password,string? department) : base(id,firstName,lastName,email,password)
        {
            Department = department;
        }

    }
    
}
