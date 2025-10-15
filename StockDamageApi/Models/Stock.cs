using System.ComponentModel.DataAnnotations;

namespace StockDamageApi.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public string SubItemCodeValue { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
    }
}
