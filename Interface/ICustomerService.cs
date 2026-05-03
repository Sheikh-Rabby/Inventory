using Inventory.Model;

namespace Inventory.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
    }
}
