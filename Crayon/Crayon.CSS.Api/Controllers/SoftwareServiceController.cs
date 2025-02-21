using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crayon.CSS.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class SoftwareServiceController : ControllerBase
{
    private readonly ICCPService _cCPService;

    public SoftwareServiceController(ICCPService cCPService)
    {
        _cCPService = cCPService;
    }

    [HttpGet()]
    public ActionResult<SoftwareService> GetAvailable()
    {
        var services = _cCPService.GetAvailableService();
        return Ok(services);
    }
}
