using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Service.Services;

public class SoftwareLicenseService : ISoftwareLicenseService
{
    private readonly ISoftwareLicenseRepository _softwareLicenseRepository;

    public SoftwareLicenseService(ISoftwareLicenseRepository softwareLicenseRepository)
    {
        _softwareLicenseRepository = softwareLicenseRepository;
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
