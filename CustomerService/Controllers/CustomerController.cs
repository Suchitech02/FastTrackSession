using Microsoft.AspNetCore.Mvc;
using CustomerService.Repository;

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
    }
}