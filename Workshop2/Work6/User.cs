﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public class User : BaseEntity<int>
    {
        public User()
        {
        }

        public User(int id,string firstName, string lastName, string email, string password):base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
    
}
