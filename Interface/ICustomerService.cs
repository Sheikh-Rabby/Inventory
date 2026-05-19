using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task AddAsync(CustomerDto customer);
    }
}
