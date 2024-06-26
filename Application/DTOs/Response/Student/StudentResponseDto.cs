using Domain.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Student
{
    public class StudentResponseDto
    {
        public long StudentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; } = string.Empty;
    }   
}
