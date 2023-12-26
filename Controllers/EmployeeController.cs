using DotNetCoreDominationBootcampDay3.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDominationBootcampDay3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly TechCareerDbContext _context;
        public EmployeeController()
        {
            _context = new TechCareerDbContext();
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _context.Employees.ToList();
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else return Ok(employee);

        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employee.CreatedAt = DateTime.Now;
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status201Created, employee);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            var savedEmployeeData = _context.Employees.Find(id);

            if (savedEmployeeData == null)
            {
                return NotFound();
            }

            savedEmployeeData.FirstName = employee.FirstName;
            savedEmployeeData.LastName = employee.LastName;
            savedEmployeeData.Address = employee.Address;
            savedEmployeeData.City = employee.City;
            savedEmployeeData.BirthDate = employee.BirthDate;
            savedEmployeeData.UpdatedAt = DateTime.Now;
            _context.Employees.Update(savedEmployeeData);
            _context.SaveChanges();
            return Ok(savedEmployeeData);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) return NotFound();
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return Ok(employee);
            }
        }
    }
}
