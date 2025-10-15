using System.ComponentModel.DataAnnotations;

namespace StockDamageApi.Models
{
    public class Godown
    {
        [Key]
        public int AutoSlNo { get; set; }
        public string GodownNo { get; set; } = string.Empty;
        public string GodownName { get; set; } = string.Empty;
    }
}
