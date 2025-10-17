namespace StockDamageBlazor.Models
{
    public class StockDamageDto
    {
        public int GodownId { get; set; }
        public int SubItemId { get; set; }
        public int CurrencyId { get; set; }
        public int EmployeeId { get; set; }

        public string ItemName { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public decimal Stock { get; set; }
        public string BatchNo { get; set; } = "NA";
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal AmountIn { get; set; }
        public string DrACHead { get; set; } = "Stock Damage";
        public string Comments { get; set; } = string.Empty;
    }
}
