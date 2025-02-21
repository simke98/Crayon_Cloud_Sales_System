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

    [HttpPost("{accountId:guid}/order")]
    public async Task<ActionResult> OrderSoftwareLicense([FromRoute] Guid accountId, [FromBody] SoftwareLicenseCreate request)
    {
        var id = await _softwareLicenseService.OrderSoftwareLicense(accountId, request); 
        return Ok(id);
    }



    [HttpPut("{id:guid}")]
    public async Task<ActionResult> Update([FromRoute] Guid id, [FromBody] SoftwareLicenseUpdate request)
    {
        await _softwareLicenseService.UpdateExpirationDate(id, request);
        return NoContent();
    }
}
