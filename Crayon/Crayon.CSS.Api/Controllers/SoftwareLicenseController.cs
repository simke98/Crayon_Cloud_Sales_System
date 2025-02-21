using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crayon.CSS.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class SoftwareLicenseController : ControllerBase
{
    private readonly ISoftwareLicenseService _softwareLicenseService;

    public SoftwareLicenseController(ISoftwareLicenseService softwareLicenseService)
    {
        _softwareLicenseService = softwareLicenseService;
    }


    [HttpPut("{id:guid}")]
    public async Task<ActionResult> Update([FromRoute] Guid id, [FromBody] SoftwareLicenseUpdate request)
    {
        await _softwareLicenseService.UpdateExpirationDate(id, request);
        return NoContent();
    }
}
