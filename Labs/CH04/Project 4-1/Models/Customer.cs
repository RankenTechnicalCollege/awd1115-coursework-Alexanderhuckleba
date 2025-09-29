using System.ComponentModel.DataAnnotations;

namespace Project4_1.Models
{
    public class Customer
    {
        public int Id { get; set; }   // Primary Key (auto-increment)

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
