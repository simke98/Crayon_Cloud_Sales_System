using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Mapper;
using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerModel> CreateCustomerAsync(CustomerRequestModel customer)
        {
            var newCustomer = new Customer() { CreatedAt = DateTime.Now, Name = customer.Name, UpdatedAt = DateTime.Now };
            var result = await _customerRepository.Create(newCustomer);

            return result.ToDtoModel();
        }

        public async Task<ICollection<AccountModel>> GetAccountsByCustomerIdAsync(Guid id)
        {
            var accounts = await _customerRepository.GetAccountByCustomerIdAsync(id);

            if (accounts == null)
            {
                throw new NotFoundException("customer/get-accounts-by-customer-id", $"Customer with ID={id} has not accounts");
            }

            var accountsMapped = accounts.Select(a => a.ToDtoModel()).ToList();

            return accountsMapped;
        }

        public async Task<CustomerModel> GetCustomerByIdAsync(Guid id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(id);

            if (customer == null)
            {
                throw new NotFoundException("customer/get-customer-by-id", $"Customer with ID={id} was not found");
            }

            return customer.ToDtoModel();
        }
    }
}
