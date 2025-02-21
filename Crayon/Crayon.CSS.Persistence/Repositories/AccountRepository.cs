using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Persistence.Repositories;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(CSSDBContext context): base(context) { }

    public async Task<ICollection<Account>> GetAccountByCustomerId(Guid customerId)
    {
        return await FindByCondition(a => a.CustomerId.Equals(customerId)).ToListAsync();
    }
}
