using Microsoft.EntityFrameworkCore;
using CustomerService.Models;
namespace CustomerService.Entityframeworkcore
{
    public class CustomerDbContext : DbContext
    {
        // Constructor chaining
        public CustomerDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}