using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public class InMemoryEmployeeRepository
    {
        private List<Employee> employees;
        public InMemoryEmployeeRepository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee(1, "Uğur", "Aydın", "aydın@gmail.com", "101010","IT"));

        }
        public void Add(Employee employee)
        {
            foreach (var item in employees)
            {
                if(employee.Id == item.Id)
                {
                    throw new Exception("User has been already");
                    break;
                }
                else
                {
                    employees.Add(employee);
                    Console.WriteLine($"User {employee.FirstName} {employee.LastName} added ");
                    break;
                }
            }
        }
        public void Delete(int id)
        {
            foreach (var item in employees)
            {
                if(item.Id == id)
                {
                    employees.Remove(item);
                    Console.WriteLine($"User {item.FirstName} {item.LastName} deleted ");
                    break;
                }
                else
                {
                    throw new Exception("");
                    break;
                }
            }
        }
        public Employee GetById(int id)
        {
            foreach (var item in employees)
            {
                if (item.Id == id)
                {
                    Console.WriteLine($"User : {item.FirstName} {item.LastName}  ");
                    return item;
                    
                }
                else
                {
                    throw new InvalidOperationException("User not found");

                }
                
            }
            return null;
        }

        public List<Employee> GetList()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName + " " +item.LastName);
            }
            return employees;

        }

    }
}
