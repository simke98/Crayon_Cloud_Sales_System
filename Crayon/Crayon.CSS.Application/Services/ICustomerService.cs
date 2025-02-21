using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Application.Services;

public interface ICustomerService
{
    Task<CustomerModel> GetCustomerByIdAsync(Guid id);
    Task<CustomerModel> CreateCustomerAsync(CustomerRequestModel customer);
    Task<ICollection<AccountModel>> GetAccountsByCustomerIdAsync(Guid id);
}
