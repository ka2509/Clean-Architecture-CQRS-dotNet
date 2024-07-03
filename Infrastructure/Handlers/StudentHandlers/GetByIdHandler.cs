using Application.Common.Mapper;
using Application.DTOs.Response.Student;
using Application.Exceptions;
using Application.Queries.StudentQuery;
using Infrastructure.Data;
using MediatR;

namespace Infrastructure.Handlers.StudentHandlers
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, StudentResponseDto>
    {
        private readonly DataContext _context;
        public GetByIdHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<StudentResponseDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var check = await _context.Students.FindAsync(request.id);
            if (check == null) throw new StudentNotFound(request.id);
            return check.ToStudentDto();
        }
    }
}
