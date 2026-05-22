using Inventory.DTO;
using Inventory.Interface.ServiceInterface;
using Inventory.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerservice;
        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }


        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
           var result = await _customerservice.GetAllAsync();
           return Ok(result);
            
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CustomerDto customer)
        {
            if (string.IsNullOrWhiteSpace(customer.customerName))
            
            return BadRequest(new { message = "CustomerName Cannot be Null or Blank" });
              
            await _customerservice.AddAsync(customer);
            return Created( string.Empty, new {message="Customer Added!"});
        }
    }
}
