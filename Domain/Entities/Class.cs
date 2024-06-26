namespace Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // Many-To-One
        public int MajorId { get; set; }
        public Major Major { get; set; }
        // One-To-Many
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
