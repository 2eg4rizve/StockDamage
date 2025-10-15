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
    public class CurrencyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CurrencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Currency
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Currency>>> GetAll()
        {
            return await _context.Currencies.ToListAsync();
        }

        // ✅ POST: api/Currency
        [HttpPost]
        public async Task<ActionResult<Currency>> Create([FromBody] Currency currency)
        {
            if (currency == null)
                return BadRequest("Currency data is null.");

            // Optional validation
            if (string.IsNullOrWhiteSpace(currency.CurrencyName))
                return BadRequest("Currency name is required.");

            _context.Currencies.Add(currency);
            await _context.SaveChangesAsync();

            // Return 201 Created + new item
            return CreatedAtAction(nameof(GetAll), new { id = currency.CurrencyID }, currency);
        }
    }
}
