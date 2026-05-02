using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface IUserService
    {
        Task<RegisterDto> Register(RegisterDto dto);
        Task<User> Login(LoginDto login);
    }
}
