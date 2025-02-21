using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crayon.CSS.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CustomerModel>> GetById([FromRoute] Guid id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        [HttpGet("{id:guid}/accounts")]
        public async Task<ActionResult<ICollection<AccountModel>>> GetAccountByCustomerId([FromRoute] Guid id)
        {
            var accounts = await _customerService.GetAccountsByCustomerIdAsync(id);
            return Ok(accounts);
        }


        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CustomerRequestModel request)
        {
            var customer = await _customerService.CreateCustomerAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }
    }
}
