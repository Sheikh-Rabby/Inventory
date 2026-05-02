using Inventory.DTO;
using Inventory.Model;


namespace Inventory.Interface
{
    public interface IUserRepository
    {
        public Task AddUser(User user);
        public Task<User> GetUserByEmail(string email);
        public Task<User> userLogin(LoginDto login);
    }
}
