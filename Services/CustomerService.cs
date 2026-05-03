using Inventory.Interface;
using Inventory.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Inventory.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var customer = await _customerRepository.GetAll();
            if (customer == null)
                return Enumerable.Empty<Customer>();
            return customer;
        }

        
    }
}
