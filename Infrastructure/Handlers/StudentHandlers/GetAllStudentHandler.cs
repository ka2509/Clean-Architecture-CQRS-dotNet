using Application.Common.Mapper;
using Application.DTOs.Response.Student;
using Application.Queries.StudentQuery;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handlers.StudentHandlers
{
    public class GetAllStudentHandler : IRequestHandler<GetAllStudentQuery, List<StudentResponseDto>>
    {
        private readonly DataContext _context;
        public GetAllStudentHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<List<StudentResponseDto>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var students = await _context.Students.AsNoTracking().ToListAsync(cancellationToken);
            var response = students.Select(s => s.ToStudentDto()).ToList();
            return response;
        }
    }
}
