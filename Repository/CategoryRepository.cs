using Inventory.Repository.BaseRepository;
using Inventory.Model;
using Inventory.Data;
using Inventory.Interface.ServiceInterface;

namespace Inventory.Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository( AppDbContext context ): base(context)
        {

        }
    }

}
