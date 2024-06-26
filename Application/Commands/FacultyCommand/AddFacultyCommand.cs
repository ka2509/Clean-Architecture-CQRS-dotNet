using Application.DTOs;
using Application.DTOs.Request;
using Domain.Entities;
using MediatR;

namespace Application.Commands.FacultyCommand
{
    public class AddFacultyCommand : IRequest<ServiceResponse>
    {
        public FacultyDto? FacultyDto { get; set; }
    }
}
