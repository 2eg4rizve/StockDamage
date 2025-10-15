using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockDamageApi.Data;
using StockDamageApi.Models;
using StockDamageApi.Dtos;

namespace StockDamageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockDamageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockDamageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all Stock Damage entries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockDamage>>> GetAll()
        {
            var list = await _context.StockDamages
                .Include(sd => sd.Godown)
                .Include(sd => sd.SubItem)
                .Include(sd => sd.Currency)
                .Include(sd => sd.Employee)
                .ToListAsync();

            return Ok(list);
        }

        // Add new Stock Damage entries
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] List<StockDamageDto> items)
        {
            if (items == null || items.Count == 0)
                return BadRequest("No items provided");

            var entities = items.Select(dto => new StockDamage
            {
                GodownId = dto.GodownId,
                SubItemId = dto.SubItemId,
                CurrencyId = dto.CurrencyId,
                EmployeeId = dto.EmployeeId,
                ItemName = dto.ItemName,
                Unit = dto.Unit,
                Stock = dto.Stock,
                BatchNo = string.IsNullOrEmpty(dto.BatchNo) ? "NA" : dto.BatchNo,
                Quantity = dto.Quantity,
                Rate = dto.Rate,
                AmountIn = dto.AmountIn,
                DrACHead = string.IsNullOrEmpty(dto.DrACHead) ? "Stock Damage" : dto.DrACHead,
                Comments = dto.Comments
            }).ToList();

            _context.StockDamages.AddRange(entities);
            await _context.SaveChangesAsync();

            return Ok("Stock Damage entries saved successfully");
        }
    }
}
