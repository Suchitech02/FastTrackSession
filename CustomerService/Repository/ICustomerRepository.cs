using CustomerService.Models;
using System;
using System.Collections.Generic;
namespace CustomerService.Repository
{
    // Perform the set of operations on table
    public interface ICustomerRepository
    {
         IEnumerable<Customer> GetCustomers();
         Customer SearchCustomer(int ID);
         int UpdateCustomer(Customer customer);
         int DeleteCustomer(int ID);
         int CreateCustomer(Customer customer);
    }
}