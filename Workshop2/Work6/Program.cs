// See https://aka.ms/new-console-template for more information

using Work6;

InMemoryCustomerRepository customerRepository = new InMemoryCustomerRepository();  //IRepository<Customer>
//InMemoryRepository<Employee> employeeRepository = new InMemoryRepository<Employee>();

//Customer added
Customer customer1 = new Customer
{
    Id = 2,
    FirstName = "Elif ",
    LastName = "Demir",
    Email = "elif@hotmail.com",
    Password = "123456",
    CreatedDate = DateTime.Now
};

Customer customer2 = new Customer
{
    Id = 3,
    FirstName = "Ali",
    LastName = "İnan",
    Email = "mhmmed@hotmail.com",
    Password = "123456",
    CreatedDate = DateTime.Now
};
customerRepository.Add(customer1);
customerRepository.GetList();

//customerRepository.Add(customer2);
//customerRepository.GetList();

//var result = customerRepository.GetById(1);
//Console.WriteLine(result.FirstName);

//customerRepository.Delete(1);
//customerRepository.GetList();


//Customer updated
Customer updatedCustomer = new Customer()
{
    Id = 1,
    FirstName = "Gulsum",
    LastName = "Ozaslan",
    Email = "glsm@example.com",
    Password = "101010",
    UpdatedDate = DateTime.Now
};
customerRepository.Update(updatedCustomer);
