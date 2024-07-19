using Microsoft.AspNetCore.Mvc;
using MediatR;
using Flex.Application.UserCases.V1.Account.Login;

namespace Flex.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateActionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CorporateActionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetCamast()
        {
            return Ok("ok");
        }
    }
}