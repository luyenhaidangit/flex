using MediatR;
using Microsoft.AspNetCore.Mvc;
using Flex.Application.Customer.ManageSemast.GetSemast;

namespace Flex.Api.Controllers
{
    [Route("api/semast")]
    [ApiController]
    public class SemastController : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public SemastController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpGet("get")]
        //public async Task<IActionResult> GetSemast([FromQuery] GetSemastRequest request, CancellationToken cancellationToken)
        //{
        //    var query = new GetSemastQuery(request);

        //    var result = await _mediator.Send(query, cancellationToken);

        //    return Ok(result);
        //}
    }
}
