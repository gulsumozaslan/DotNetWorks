using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public class InMemoryCustomerRepository/* : IRepository<T> where T : User */
    {
        private List<Customer> data ;

        public InMemoryCustomerRepository()
        {
            data = new List<Customer>();
            data.Add(new Customer(1,"Gülsüm","Özaslan","gulsum@hotmail.com","123456","Antalya","1221021"));
        }

        public void Add(Customer entity)
        {
            foreach (var user in data)
            {
                if (user.FirstName == entity.FirstName.Trim())
                {
                    Console.WriteLine("User has been already exist");
                    break;
                    

                }
                else
                {
                    data.Add(entity);
                    Console.WriteLine("User " + entity.FirstName + " " + entity.LastName + " added");
                    break;
                }
            }

        }

        public void Delete(int id)
        {
            foreach (var item in data)
            {
                if (item.Id == id)
                {

                    data.Remove(item);
                    Console.WriteLine("User " + item.FirstName + " " + item.LastName + " deleted");
                    item.DeletedDate = DateTime.Now;
                    break;
                }
                else
                {
                    throw new InvalidOperationException("Entity not found");
                    break;
                }
            }
            
        }
        public void Update(Customer entity)
        {
            foreach (var item in data)
            {
                if (item.Id == entity.Id)
                {

                    item.FirstName = entity.FirstName;
                    item.LastName = entity.LastName;
                    item.Email = entity.Email;
                    item.Password = entity.Password;
                    item.UpdatedDate = DateTime.Now;

                    Console.WriteLine("User " + item.FirstName + " " + item.LastName + " updated");
                    break;
                }
                else
                {
                    throw new InvalidOperationException("Entity not found");
                    break;
                }
            }

        }

        public Customer GetById(int id)
        {
            
            foreach (var item in data)
            {
                if (item.Id == id)
                {
                    return item;

                }
            }
            return null;

        }

        public List<Customer> GetList()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            //return data;
            return data.FindAll(d => d.DeletedDate == null);
        }


    }
}
