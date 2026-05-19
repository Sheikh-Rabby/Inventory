using Inventory.DTO;
using Inventory.Interface;
using Inventory.Model;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerservice;
        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }


        [HttpGet("GetALL")]
        public async Task <IActionResult> GetAll()
        {
           var result = await _customerservice.GetAllAsync();
            if (!result.Any())
            {
                return NotFound(new { message = "User Not Found" });
            }
           return Ok(result);
            
        }
        [HttpPost("addcustomer")]
        public async Task<IActionResult> AddAsync([FromBody] CustomerDto customer)
        {
            if (string.IsNullOrWhiteSpace(customer.customerName)) 
            {
                return BadRequest("CustomerName Null or Blank");
            }    
            await _customerservice.AddAsync(customer);
            return Ok(new {message="Customer Added!"});
        }
    }
}
