using Application.DTOs.Response.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Class
{
    public record ClassView(string Name, string Major, List<StudentResponseDto> Students);
}
