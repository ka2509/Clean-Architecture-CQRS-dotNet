using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //One-To-Many
        public List<Major> Majors { get; set; } = new List<Major>();
    }
}
