using Inventory.Interface;
using Inventory.Model;

namespace Inventory.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerService _customerService;

        public CustomerService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var customer = await _customerService.GetAll();
            return customer;
        }
    }
}
