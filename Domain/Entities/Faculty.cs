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
