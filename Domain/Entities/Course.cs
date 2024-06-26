namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Enrollment { get; set; }
        public int MajorId { get; set; }
        public Major Major { get; set; }
        public string Semester { get; set; } = string.Empty;
        // Many-To-Many
        public List<CourseGrade> CourseGrades { get; set; } = new List<CourseGrade>();
    }
}
