using Application.DTOs;
using Application.DTOs.Request.Faculty;
using MediatR;

namespace Application.Commands.FacultyCommand
{
    public record AddFacultyCommand(FacultyDto FacultyDto) : IRequest<ServiceResponse>;
}
