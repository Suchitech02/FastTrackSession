using Microsoft.AspNetCore.Mvc;
using CustomerService.Repository;
using CustomerService.Models;

namespace CustomerService.Controllers
{
    [ApiController]
    [Route("[controller]")] // controller is representig the customer
    public class CustomerController : ControllerBase
    {
        ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet("CustomerList")]
        public ActionResult GetCustomerList()
        {
            return Ok(customerRepository.GetCustomers());
        }

        [HttpPost("CreateCustomer")]
        public ActionResult CreateCustomer(Customer obj)
        {
            return Ok(customerRepository.CreateCustomer(obj));
        }
    }
}