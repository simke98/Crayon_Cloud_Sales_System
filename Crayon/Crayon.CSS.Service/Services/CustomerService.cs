using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Mapper;
using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;

namespace Crayon.CSS.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
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
