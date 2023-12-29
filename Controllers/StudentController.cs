using DotNetCoreDominationBootcampDay3.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreDominationBootcampDay3.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : ControllerBase
    {
        TechCareerDbContext _techCareerDbContext;
        public StudentController( TechCareerDbContext techCareerDbContext)
        {
            _techCareerDbContext = techCareerDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var student = _techCareerDbContext.students.Include(x=>x.Courses).ToList();
            return Ok(student);
        }
    }
}
