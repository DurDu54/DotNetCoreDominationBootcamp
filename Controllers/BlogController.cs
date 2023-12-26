using DotNetCoreDominationBootcampDay3.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDominationBootcampDay3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly TechCareerDbContext _context;
        public BlogController()
        {
            _context = new TechCareerDbContext();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _context.Blogs.ToList();
            return Ok(employee);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _context.Blogs.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else return Ok(employee);

        }


        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status201Created, blog);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Blogs.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else
            {
                _context.Blogs.Remove(employee);
                _context.SaveChanges();
                return Ok(employee);
            }
        }
    }
}
