using System;

namespace StockDamageBlazor.Models
{
    public class StockDamageViewModel
    {
        public int GodownId { get; set; }
        public int SubItemCodeId { get; set; }
        public int StockId { get; set; }
        public int CurrencyId { get; set; }
        public int EmployeeId { get; set; }
        public decimal DamageQuantity { get; set; }
        public string DamageReason { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
