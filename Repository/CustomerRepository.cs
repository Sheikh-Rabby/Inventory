using Inventory.Data;
using Inventory.Interface;
using Inventory.Model;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
           return await _context.Customers.ToListAsync();
        }
    }
}
