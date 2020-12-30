using System.Collections.Generic;
using CustomerService.Models;
using CustomerService.Entityframeworkcore;

namespace CustomerService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDbContext customerDb;
        public CustomerRepository(CustomerDbContext customerDb)
        {
            this.customerDb = customerDb;
        }
        public int CreateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteCustomer(int ID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new System.NotImplementedException();
        }

        public Customer SearchCustomer(int ID)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}