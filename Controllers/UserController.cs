using Inventory.DTO;
using Inventory.Interface;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController :ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       [HttpPost("register")]
       public async Task<ActionResult> Register([FromBody] RegisterDto dto)
       {
            try
            {
            var result= await _userService.Register(dto);
           
            return Ok(result);
            }
            catch(ConflictException ex)
            {
                return Conflict(new { message = ex.Message });
            }

       }
        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] LoginDto dto)
        {
            try
            {
                var result = await _userService.Login(dto);
                return Ok(result);
            }
            catch(NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
                
            
        }
    }
}
