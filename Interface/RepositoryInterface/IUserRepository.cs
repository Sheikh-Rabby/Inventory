using Inventory.Model;

namespace Inventory.Interface.RepositoryInterface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetUserByEmail(string email);
    }
}