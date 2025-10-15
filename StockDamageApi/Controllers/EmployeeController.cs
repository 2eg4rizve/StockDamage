using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockDamageApi.Data;
using StockDamageApi.Models;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
