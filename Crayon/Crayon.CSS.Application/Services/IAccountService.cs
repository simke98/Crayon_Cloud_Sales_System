using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Application.Services
{
    public interface IAccountService
    {
        Task<ICollection<Account>> GetAllAccountsByCustomerId(Guid customerId);
    }
}
