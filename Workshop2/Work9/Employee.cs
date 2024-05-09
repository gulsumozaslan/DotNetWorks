using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work9
{
    public class Employee
    {
        private string name;
        private int age;
        private double salary;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary 
        { 
            get { return salary; }  
            set { salary = value+(value*10/100); }
        }
    }
}
