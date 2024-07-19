using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Flex.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateActionController : ControllerBase
    {
        private readonly IMediator _mediator;
    }
}