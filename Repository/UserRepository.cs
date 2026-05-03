using Inventory.Data;
using Inventory.DTO;
using Inventory.Interface;
using Inventory.Model;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.email == email);
        }

        public async Task<User?> userLogin(LoginDto login)
        {
           return await _context.Users.FirstOrDefaultAsync(e => e.email == login.email && e.password==login.password);
        }

        
    }
}
