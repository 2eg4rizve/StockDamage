namespace StockDamageBlazor.Models
{
    public class CurrencyDto
    {
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public decimal Rate { get; set; }
    }
}
