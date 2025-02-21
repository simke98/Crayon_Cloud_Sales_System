using Crayon.CSS.Application.DtoModels;

namespace Crayon.CSS.Application.Services;

public interface ICustomerService
{
    Task<CustomerModel> GetCustomerByIdAsync(Guid id);
}
