using Domain.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        // Many-to-one
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; } = string.Empty;
        public List<CourseGrade> CourseGrades { get; set; } = new List<CourseGrade>();
        public List<UserRole> UserRoles { get; set; } = new List<UserRole> { };
    }
}
