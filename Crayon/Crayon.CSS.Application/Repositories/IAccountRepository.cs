using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Application.Repositories;

public interface IAccountRepository : IRepositoryBase<Account>
{
    Task<ICollection<Account>> GetAccountByCustomerId(Guid customerId);

}
