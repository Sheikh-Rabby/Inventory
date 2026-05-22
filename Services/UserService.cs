using Inventory.DTO;
using Inventory.Interface.RepositoryInterface;
using Inventory.Interface.ServiceInterface;
using Inventory.Model;

namespace Inventory.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public UserService(IUserRepository userRepository, JwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<ResponseDto> Register(RegisterDto dto)
        {
            var exists = await _userRepository.GetUserByEmail(dto.email);

            if (exists != null)
                throw new ConflictException("Email Already Exists");

            var user = new User
            {
                userName = dto.username,
                email = dto.email,
                password = dto.password,
                isActive = "true",
                phone = "01965236885"
            };

            await _userRepository.AddAsync(user);

            return new ResponseDto
            {
                username = user.userName,
                message  = "User created!",
            };
        }

        public async Task<LoginResponseDto> Login(LoginDto login)
        {
            var user = await _userRepository.GetUserByEmail(login.email);
            if (user == null)
            {
                throw new NotFoundException("User or email not Found");
            }

            if (user.password != login.password)
            {
                throw new Exception("Invalid Password");
            }

            var token = _jwtService.GenerateToken(user);



            return new LoginResponseDto
            {
                username = user.userName,
                message = "Login successful",
                token = token
            };
        }
    }
}