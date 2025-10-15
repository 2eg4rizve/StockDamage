using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockDamageApi.Data;
using StockDamageApi.Models;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Godown>>> GetAll()
        {
            return await _context.Godowns.ToListAsync();
        }
    }
}
