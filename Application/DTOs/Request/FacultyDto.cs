using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class FacultyDto
    {
        public string Name { get; set; } = string.Empty;
        public FacultyDto(string Name)
        {
            this.Name = Name;
        }
    }
}
