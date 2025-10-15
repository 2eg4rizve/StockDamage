using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockDamageApi.Data;
using StockDamageApi.Models;

namespace StockDamageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubItemCodeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubItemCodeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubItemCode>>> GetAll()
        {
            return await _context.SubItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubItemCode>> GetById(int id)
        {
            var item = await _context.SubItems.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }
    }
}
