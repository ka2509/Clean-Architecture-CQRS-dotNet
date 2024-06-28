using Application.DTOs.Response.Grade;
using Application.Queries.GradeQuery;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Handlers.GradeHandlers
{
    public class GradeViewHandler : IRequestHandler<GradeViewQuery, List<GradeView>>
    {
        private readonly DataContext _context;
        public GradeViewHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<List<GradeView>> Handle(GradeViewQuery request, CancellationToken cancellationToken)
        {
            var courseGrades = _context.CourseGrades.AsNoTracking().AsQueryable();
            if (request.studentId == null) return null;
            var studentGrades = await courseGrades.Where(s => s.StudentId.Equals(request.studentId)).ToListAsync();
            List<GradeView> gradeViews = new List<GradeView>();
            foreach(var studentGrade in studentGrades)
            {
                var course = await _context.Courses.FindAsync(studentGrade.CourseId);
                gradeViews.Add(new GradeView(course.Name, studentGrade.Grade));
            }
            return gradeViews;
        }
    }
}
