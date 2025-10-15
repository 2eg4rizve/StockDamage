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
    public class SubItemCodeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubItemCodeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SubItemCode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubItemCode>>> GetAll()
        {
            return await _context.SubItems.ToListAsync();
        }

        // GET: api/SubItemCode/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SubItemCode>> GetById(int id)
        {
            var item = await _context.SubItems.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        // POST: api/SubItemCode
        [HttpPost]
        public async Task<ActionResult<SubItemCode>> Create([FromBody] SubItemCode subItem)
        {
            if (subItem == null)
                return BadRequest("SubItem data is null.");

            // Optional validation
            if (string.IsNullOrWhiteSpace(subItem.SubItemName))
                return BadRequest("SubItem name is required.");
            if (string.IsNullOrWhiteSpace(subItem.SubItemCodeValue))
                return BadRequest("SubItem code is required.");

            _context.SubItems.Add(subItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = subItem.AutoSlNo }, subItem);
        }
    }
}
