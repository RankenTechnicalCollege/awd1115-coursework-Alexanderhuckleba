using System.ComponentModel.DataAnnotations;

namespace Project3_1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
    }
}
