using System.Collections.Generic;
using CustomerService.Models;
using CustomerService.Entityframeworkcore;
using System.Linq;
using System;

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

        public int DeleteCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            customerDb.Customers.Remove(customer); // Removing from local memory
            return customerDb.SaveChanges(); 
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return this.customerDb.Customers.ToList();  // Customers from customerDbContext
        }

        public Customer SearchCustomer(int ID)
        {
            return customerDb.Customers.SingleOrDefault(temp => temp.ID == ID);
        }

        public int UpdateCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            return customerDb.SaveChanges();

        }
    }
}