using Inventory.Data;
using Inventory.DTO;
using Inventory.Interface;
using Inventory.Model;
using Inventory.Repository.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        
        public CustomerRepository(AppDbContext context):base(context)
        {
            
        }

       
    }
}
