using System.ComponentModel.DataAnnotations;

namespace Project4_1.Models
{
    public class Item
    {
        public int Id { get; set; }   // Primary key

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)] 
        public string Description { get; set; }
    }
}
