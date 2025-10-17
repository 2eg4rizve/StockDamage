namespace StockDamageBlazor.Models
{
    public class Currency
    {
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public decimal ConversionRate { get; set; }
    }
}
