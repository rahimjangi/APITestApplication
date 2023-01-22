using System.ComponentModel.DataAnnotations;

namespace APITest.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
        [Required]
        public int Ammount { get; set; }
    }
}
