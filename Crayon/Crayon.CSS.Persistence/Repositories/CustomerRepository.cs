using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Persistence.Repositories;

public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
{
    public CustomerRepository(CSSDBContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public async Task<ICollection<Account>> GetAccountByCustomerIdAsync(Guid id)
    {
        var customer = await FindByCondition(c => c.Id.Equals(id)).Include(c => c.Accounts).FirstOrDefaultAsync();

        return customer.Accounts;
    }

    public async Task<Customer> GetCustomerByIdAsync(Guid id)
    {
        return await FindByCondition(c => c.Id.Equals(id)).FirstOrDefaultAsync();
    }
}
