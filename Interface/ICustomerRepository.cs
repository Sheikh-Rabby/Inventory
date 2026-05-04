using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task AddCustomer(Customer customer);  
    }
}
