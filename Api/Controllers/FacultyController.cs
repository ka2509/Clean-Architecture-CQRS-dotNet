using Application.Commands.FacultyCommand;
using Application.DTOs.Request.Faculty;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacultyController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FacultyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddFaculty([FromBody] FacultyDto facultyDto) => Ok(await _mediator.Send(new AddFacultyCommand(facultyDto)));
    }
}
