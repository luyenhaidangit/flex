using Asp.Versioning;
using Flex.Application.UserCases.V1.Account.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Flex.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ApiVersion("1.0")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] CreateCamastCommand command)
        //{
        //    var token = await _mediator.Send(command);
        //    if (token == null)
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(new { Token = token });
        //}
    }
}
