using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Entities;
using Crayon.CSS.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ICCPService _cpService;

        public AccountService(IAccountRepository accountRepository, ICCPService cpService)
        {
            _accountRepository = accountRepository;
            _cpService = cpService;
        }

        public async Task CancelLicense(Guid accountId, Guid softwareLicenseId)
        {
            var account = await _accountRepository.FindByCondition(a => a.Id.Equals(accountId)).Include(a => a.SoftwareLicenses).FirstOrDefaultAsync();

            if (account == null)
            {
                throw new NotFoundException("account/cancel-license", $"Account with ID={accountId} was not found");
            }

            var license = account.SoftwareLicenses.FirstOrDefault(sl => sl.Id.Equals(softwareLicenseId));

            if (license == null)
            {
                throw new NotFoundException("account/cancel-license", $"SoftwareLicenses with ID={softwareLicenseId} was not found");
            }

            license.State = LicensesState.Canceled;
            await _accountRepository.Update(account);
        }

        public async Task<ICollection<Account>> GetAllAccountsByCustomerId(Guid customerId)
        {
            var accounts = await _accountRepository.GetAccountByCustomerId(customerId);

            return accounts;
        }

        public async Task UpdateLicenseQuantity(Guid accountId, Guid softwareLicenseId, int quantity)
        {
            var account = await _accountRepository.FindByCondition(a => a.Id.Equals(accountId)).Include(a => a.SoftwareLicenses).FirstOrDefaultAsync();

            if (account == null)
            {
                throw new NotFoundException("account/update-license-quantity", $"Account with ID={accountId} was not found");
            }

            var license = account.SoftwareLicenses.FirstOrDefault(sl => sl.Id.Equals(softwareLicenseId));

            if (license == null)
            {
                throw new NotFoundException("account/update-license-quantity", $"SoftwareLicenses with ID={softwareLicenseId} was not found");
            }

            if (!_cpService.IsAvailable(license.SoftwareName, quantity))
            {
                throw new UpdateException("account/update-license-quantity", $"The software '{license.SoftwareName}' does not have {quantity} available licenses.");
            }

            license.Quantity = quantity;
            await _accountRepository.Update(account);
        }
    }
}
