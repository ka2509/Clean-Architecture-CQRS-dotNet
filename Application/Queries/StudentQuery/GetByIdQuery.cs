using Application.DTOs.Response.Student;
using MediatR;

namespace Application.Queries.StudentQuery
{
    public record GetByIdQuery(string id) : IRequest<StudentResponseDto>;
}
