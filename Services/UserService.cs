using Inventory.DTO;
using Inventory.Interface;
using Inventory.Model;
using Inventory.Repository;

namespace Inventory.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<RegisterDto> Register(RegisterDto dto)
        {
            var exists= await _userRepository.GetUserByEmail(dto.email);
            if(exists != null)
            {
                throw new ConflictException("Email Already Exists");

            }
            var user = new User 
            {
                userName = dto.username,
                email = dto.email,
                password = dto.password,
                isActive = "true",
                phone = "01965236885"
            };

            await _userRepository.AddUser(user);
           
            return new RegisterDto
            {
                username = user.userName,
                email = user.email,
                
            };

        }

        public async Task<User> Login(LoginDto login)
        {
            
            var result = await _userRepository.userLogin(login);
            if(result == null)
            {
                throw new NotFoundException("User or email not Found");
            }
            return result;

        }
    }
}
