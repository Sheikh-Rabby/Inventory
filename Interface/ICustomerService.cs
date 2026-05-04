using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        Task AddCustomer(CustomerDto customer);
    }
}
