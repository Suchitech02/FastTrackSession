using System.Collections.Generic;
using CustomerService.Models;
using CustomerService.Entityframeworkcore;
using System.Linq;

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
            this.customerDb.Add(customer);
            return this.customerDb.SaveChanges();
        }

        public int DeleteCustomer(int ID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return this.customerDb.Customers.ToList();  // Customers from customerDbContext
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