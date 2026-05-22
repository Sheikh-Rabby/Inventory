using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface.ServiceInterface
{
    public interface ICategoryService
    {
        Task AddAsync(CreateCategoryDto categoryDto);
    }
}
