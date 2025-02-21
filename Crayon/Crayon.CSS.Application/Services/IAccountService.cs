using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Application.Services
{
    public interface IAccountService
    {
        Task<ICollection<Account>> GetAllAccountsByCustomerId(Guid customerId);
        Task UpdateLicenseQuantity(Guid accountId, Guid softwareLicenseId, int quantity);
        Task CancelLicense(Guid accountId, Guid softwareLicenseId);
    }
}
