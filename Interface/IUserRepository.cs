using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
       Task<User?> GetUserByEmail(string email);
        
    }
}
