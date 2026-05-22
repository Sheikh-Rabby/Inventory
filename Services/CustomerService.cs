using Inventory.DTO;
using Inventory.Interface;
using Inventory.Interface.ServiceInterface;
using Inventory.Model;

namespace Inventory.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IBaseRepository<Customer> _customerRepository;

        public CustomerService(IBaseRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var customer = await _customerRepository.GetAllAsync();
            if (customer == null)
                return Enumerable.Empty<Customer>();
            return customer;
        }

        public async Task AddAsync(CustomerDto dto)
        {
            var customer = new Customer
            {
                customerName = dto.customerName
            };

            await _customerRepository.AddAsync(customer);
        }
    }
}