using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockDamageApi.Data;
using StockDamageApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StockDamageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        // ✅ POST: api/Employee
        [HttpPost]
        public async Task<ActionResult<Employee>> Create([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest("Employee data is null.");

            // Optional validation
            if (string.IsNullOrWhiteSpace(employee.EmployeeName))
                return BadRequest("Employee name is required.");

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            // Return 201 Created + new employee
            return CreatedAtAction(nameof(GetAll), new { id = employee.EmployeeID }, employee);
        }
    }
}
