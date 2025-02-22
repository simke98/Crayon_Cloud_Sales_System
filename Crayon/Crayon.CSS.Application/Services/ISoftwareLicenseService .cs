﻿using Crayon.CSS.Application.DtoModels;

namespace Crayon.CSS.Application.Services;

public interface ISoftwareLicenseService
{
    Task UpdateExpirationDate(Guid id, SoftwareLicenseUpdate request);
    Task<Guid> OrderSoftwareLicense(Guid id, SoftwareLicenseCreate request);  
}
