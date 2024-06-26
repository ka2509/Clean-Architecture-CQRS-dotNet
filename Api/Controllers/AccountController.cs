using Application.Commands.AccountCommand;
using Application.DTOs;
using Application.DTOs.Request.Account;
using Application.DTOs.Response.Account;
using Application.Queries.AccountQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator   = mediator;
        }
        [HttpPost("login")]
        public async Task<ActionResult<AccountResult>> login([FromBody] LoginDto loginDto) => Ok(await _mediator.Send(new LoginAccountQuery(loginDto)));
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse>> register([FromBody] RegisterDto register) => Ok(await _mediator.Send(new RegisterAccountCommand(register)));
    }
}
