namespace StockDamageBlazor.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public string SubItemCodeValue { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
    }
}
