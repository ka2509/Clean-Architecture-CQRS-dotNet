using Application.DTOs.Response.Student;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.StudentQuery
{
    public class GetAllStudentQuery : IRequest<List<Student>> { }
}
