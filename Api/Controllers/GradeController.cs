using Application.Queries.GradeQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Security.Claims;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GradeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ViewGrade() => Ok(await _mediator.Send(new GradeViewQuery(User.FindFirst(ClaimTypes.NameIdentifier)?.Value)));
    }
}
