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
}
