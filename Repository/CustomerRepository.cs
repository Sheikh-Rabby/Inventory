using Inventory.Data;
using Inventory.Interface;
using Inventory.Model;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _dbContext;
        public CustomerRepository(AppDbContext dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
           return await _dbContext.Customers.ToListAsync();
        }
    }
}
