using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Crayon.CSS.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CustomerModel>> GetCustomerById([FromRoute] Guid id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }
    }
}
