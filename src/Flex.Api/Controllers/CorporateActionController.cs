using Microsoft.AspNetCore.Mvc;
using MediatR;
using Flex.Application.CorporateAction.ManageCamast.GetCamast;

namespace Flex.Api.Controllers
{
    [Route("api/corporate-action")]
    [ApiController]
    public class CorporateActionController : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public CorporateActionController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpGet("get")]
        //public async Task<IActionResult> GetCamast([FromQuery] GetCamastRequest request, CancellationToken cancellationToken)
        //{
        //    var query = new GetCamastQuery(request);

        //    var result = await _mediator.Send(query, cancellationToken);

        //    return Ok(result);
        //}
    }
}