using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Application.Repositories;

public interface ICustomerRepository : IRepositoryBase<Customer>
{
    Task<Customer> GetCustomerByIdAsync(Guid id);
}
