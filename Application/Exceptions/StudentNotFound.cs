using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class StudentNotFound : Exception
    {
        public string StudentId { get; set; }
        public StudentNotFound(string id) : base($"Student with ID {id} was not found.")
            => StudentId = id;
    }
}
