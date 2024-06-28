using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Grade
{
    public record GradeView(string Course, decimal Grade);
}
