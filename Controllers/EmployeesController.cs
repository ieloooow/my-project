using ASPNETCoreApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ASPNETCoreApplication.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public EmployeesController(ApplicationDBContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = _context.Employees2.ToList();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var employees = _context.Employees2.Find(id);

            if(employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}
