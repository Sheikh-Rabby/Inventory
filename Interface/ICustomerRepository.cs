using Inventory.DTO;
using Inventory.Model;

namespace Inventory.Interface
{
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        Task AddAsync(Customer customer);
    }
}
