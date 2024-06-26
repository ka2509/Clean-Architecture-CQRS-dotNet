using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CourseGrade
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Grade { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
