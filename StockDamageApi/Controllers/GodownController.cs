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
    public class GodownController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GodownController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Godown
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Godown>>> GetAll()
        {
            return await _context.Godowns.ToListAsync();
        }

        // ✅ POST: api/Godown
        [HttpPost]
        public async Task<ActionResult<Godown>> Create([FromBody] Godown godown)
        {
            if (godown == null)
                return BadRequest("Godown data is null.");

            // Optional validation
            if (string.IsNullOrWhiteSpace(godown.GodownName))
                return BadRequest("Godown name is required.");

            _context.Godowns.Add(godown);
            await _context.SaveChangesAsync();

            // Return 201 Created + new godown
            return CreatedAtAction(nameof(GetAll), new { id = godown.GodownNo }, godown);
        }
    }
}
