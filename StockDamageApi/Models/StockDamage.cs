using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockDamageApi.Models
{
    public class StockDamage
    {
        [Key]
        public int DamageID { get; set; }

        // Foreign Keys
        public int GodownId { get; set; }
        public int SubItemId { get; set; }
        public int CurrencyId { get; set; }
        public int EmployeeId { get; set; }

        // Other fields
        public string ItemName { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public decimal Stock { get; set; }
        public string BatchNo { get; set; } = "NA";
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal AmountIn { get; set; }
        public string DrACHead { get; set; } = "Stock Damage";
        public string Comments { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation properties
        [ForeignKey("GodownId")]
        public Godown Godown { get; set; } = null!;
        [ForeignKey("SubItemId")]
        public SubItemCode SubItem { get; set; } = null!;
        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; } = null!;
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = null!;
    }
}
