using Application.Common.Mapper;
using Application.DTOs.Response.Class;
using Application.Queries.ClassQuery;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handlers.ClassHandlers
{
    public class ClassViewHandler : IRequestHandler<ClassViewQuery, List<ClassView>>
    {
        private readonly DataContext _context;
        public ClassViewHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ClassView>> Handle(ClassViewQuery request, CancellationToken cancellationToken)
        {
            var classes = await _context.Classes.Include(c => c.Students).AsNoTracking().ToListAsync();
            List<ClassView> response = new List<ClassView>();
            foreach (var c in classes)
            {
                //var students = await _context.Students.Where(s => s.ClassId == c.Id).ToListAsync();
                var students = c.Students;
                var studentDtos = students.Select(s => s.ToStudentDto()).ToList();
                response.Add(new ClassView(c.Name, _context.Majors.Find(c.MajorId).Name, studentDtos));
            }
            return response;
        }
    }
}
