using Inventory.Data;
using Inventory.Model;
using Inventory.Repository.BaseRepository;

namespace Inventory.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}