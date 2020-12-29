using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CustomerService.Models
{
    public class CustomerSchema 
    {
        // Implementing Fluent API for validating the structure of Model (Avoid Data Annotation)
        public CustomerSchema(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Email);

        }
    }
}