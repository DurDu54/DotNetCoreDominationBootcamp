namespace DotNetCoreDominationBootcampDay3.Models.ORM
{
    public class Course: baseModel
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } 
    }
}
