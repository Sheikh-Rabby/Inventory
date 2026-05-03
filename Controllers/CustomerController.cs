using Inventory.Interface;
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
           var result = await _customerservice.GetAll();
            if (!result.Any())
            {
                return NotFound(new { message = "User Not Found" });
            }
           return Ok(result);
            
        }
    }
}
