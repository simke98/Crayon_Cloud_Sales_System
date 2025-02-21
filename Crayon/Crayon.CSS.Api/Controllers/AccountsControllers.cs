using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crayon.CSS.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }


    [HttpPut("{accountId:guid}/software-licenses/{softwareLicenseId:guid}/quantity")]
    public async Task<ActionResult> UpdateLicenseQuantity([FromRoute] Guid accountId, [FromRoute] Guid softwareLicenseId, [FromBody] UpdateQuantityRequest request)
    {
        if (request.Quantity <= 0)
        {
            return BadRequest();
        }

        await _accountService.UpdateLicenseQuantity(accountId, softwareLicenseId, request.Quantity);
        return NoContent();
    }


    [HttpDelete("{accountId:guid}/software-licenses/{softwareLicenseId:guid}/cancel")]
    public async Task<ActionResult> CancelSoftware([FromRoute] Guid accountId, [FromRoute] Guid softwareLicenseId)
    {
        await _accountService.CancelLicense(accountId, softwareLicenseId);

        return NoContent();
    }
}
