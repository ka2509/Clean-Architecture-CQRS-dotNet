using Application.DTOs.Response.Student;
using Application.Queries.StudentQuery;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers.StudentHandlers
{
    // IRequestHandler nhận vào TRequest là T value mà chúng ta đã tạo ở StudentQuery và trả lại một TResponse 
    public class GetAllStudentHandler : IRequestHandler<GetAllStudentQuery, List<Student>>
    {
        private readonly DataContext _context;
        public GetAllStudentHandler(DataContext context)
        {
            _context = context;
        }
        //AsNoTracking là để EF core lấy dữ liệu từ database ra dưới dạng read-only
        public async Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        => await _context.Students.AsNoTracking().ToListAsync(cancellationToken);
    }
}
