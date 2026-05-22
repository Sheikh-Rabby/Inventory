using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface.ServiceInterface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllAsync();

        Task AddAsync(CustomerDto customer);
    }
}