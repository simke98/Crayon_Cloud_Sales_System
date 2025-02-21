using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ICollection<Account>> GetAllAccountsByCustomerId(Guid customerId)
        {
            var accounts = await _accountRepository.GetAccountByCustomerId(customerId);

            return accounts;
        }
    }
}
