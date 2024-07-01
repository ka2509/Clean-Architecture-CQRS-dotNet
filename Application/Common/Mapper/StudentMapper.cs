using Application.DTOs.Response.Student;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapper
{
    public static class StudentMapper
    {
        public static StudentResponseDto ToStudentDto (this Student model)
        {
            return new StudentResponseDto(model.StudentId, model.Name, model.Gender, model.ClassId, model.Dob, model.Address);
        }
    }
}
