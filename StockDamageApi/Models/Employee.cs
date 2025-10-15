using System.ComponentModel.DataAnnotations;

namespace StockDamageApi.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
    }
}
