using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface.ServiceInterface
{
    public interface IUserService
    {
        Task<ResponseDto> Register(RegisterDto dto);

        Task<LoginResponseDto> Login(LoginDto login);
    }
}