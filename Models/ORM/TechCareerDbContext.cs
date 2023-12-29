using Microsoft.EntityFrameworkCore;

namespace DotNetCoreDominationBootcampDay3.Models.ORM
{
    public class TechCareerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test;Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Student> students{ get; set; }
        public DbSet<Course> Courses{ get; set; }
    }
}
