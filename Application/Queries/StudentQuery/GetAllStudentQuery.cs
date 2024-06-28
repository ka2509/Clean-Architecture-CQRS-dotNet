using Application.DTOs.Response.Student;
using Domain.Entities;
using MediatR;

namespace Application.Queries.StudentQuery
{
    public record GetAllStudentQuery : IRequest<List<StudentResponseDto>>;
}
