using Inventory.Data;
using Inventory.DTO;
using Inventory.Interface;
using Inventory.Model;
using Inventory.Repository.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        
        public UserRepository(AppDbContext context) : base(context)
        {
          
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.email == email);
        }

    }
}
