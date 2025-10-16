namespace StockDamageBlazor.Models
{
    public class SubItemCodeDto
    {
        public int AutoSlNo { get; set; }
        public string SubItemCodeValue { get; set; } = string.Empty;
        public string SubItemName { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public decimal Weight { get; set; }
    }
}
