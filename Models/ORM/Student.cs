namespace DotNetCoreDominationBootcampDay3.Models.ORM
{
    public class Student: baseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

    }
}
