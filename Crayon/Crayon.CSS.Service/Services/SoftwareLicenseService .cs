using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Entities;
using Crayon.CSS.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Service.Services;

public class SoftwareLicenseService : ISoftwareLicenseService
{
    private readonly ISoftwareLicenseRepository _softwareLicenseRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly ICCPService _cpService;
    public SoftwareLicenseService(ISoftwareLicenseRepository softwareLicenseRepository, ICCPService cCPService, IAccountRepository accountRepository)
    {
        _softwareLicenseRepository = softwareLicenseRepository;
        _cpService = cCPService;
        _accountRepository = accountRepository;
    }

    public async Task<Guid> OrderSoftwareLicense(Guid accountId, SoftwareLicenseCreate request)
    {
        var account = await _accountRepository.FindByCondition(a => a.Id.Equals(accountId)).FirstOrDefaultAsync();

        if (account == null)
        {
            throw new NotFoundException("softwareLicense/order-software-license", $"Account with ID={accountId} was not found");
        }

        if (!_cpService.IsAvailable(request.SoftwareName, request.Quantity))
        {
            throw new UpdateException("softwareLicense/order-software-license", $"The software '{request.SoftwareName}' does not have {request.Quantity} available licenses.");
        }

        if (request.ExpirationDate <= DateTime.Now)
        {
            throw new ValidationException("softwareLicense/order-software-license-validation", "Expiration date can't be in the past.");
        }

        var license = new SoftwareLicense
        {
            AccountId = accountId,
            ExpirationDate = request.ExpirationDate,
            Quantity = request.Quantity,
            SoftwareName = request.SoftwareName,
            State = LicensesState.Active,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        var result = await _softwareLicenseRepository.Create(license);
        return result.Id;
    }

    public async Task UpdateExpirationDate(Guid id, SoftwareLicenseUpdate request)
    {
        var sl = await _softwareLicenseRepository.FindByCondition(sl => sl.Id.Equals(id)).FirstOrDefaultAsync();

        if (sl == null)
        {
            throw new NotFoundException("softwareLicense/update-expiration-date", $"SoftwareLicense with ID={id} was not found");
        }

        sl.ExpirationDate = request.ExpirationDate;
        await _softwareLicenseRepository.Update(sl);

    }
}
