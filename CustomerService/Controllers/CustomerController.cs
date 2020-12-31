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

        [HttpPut("UpdateCustomer")]
        public ActionResult UpdateCustomer(Customer obj)
        {
            return Ok(customerRepository.UpdateCustomer(obj));
        }
        [HttpDelete("DeleteCustomer")]
        public ActionResult DeleteCustomer(Customer obj)
        {
            return Ok(customerRepository.DeleteCustomer(obj));
        }
        [HttpGet("SearchCustomer")]
        public ActionResult SearchCustomer(int ID)
        {
            return Ok(customerRepository.SearchCustomer(ID));
        }
    }
}