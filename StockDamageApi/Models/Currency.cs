using System.ComponentModel.DataAnnotations;

namespace StockDamageApi.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public decimal ConversionRate { get; set; }
    }
}
