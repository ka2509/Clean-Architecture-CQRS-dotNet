namespace Domain.Entities
{
    public class Major
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        //One-To-Many
        public List<Class> Classes { get; set; } = new List<Class>();
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
