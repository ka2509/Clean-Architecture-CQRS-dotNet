using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRole
    {
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string RoleName { get; set; }
        public Role Role { get; set; }
    }
}
