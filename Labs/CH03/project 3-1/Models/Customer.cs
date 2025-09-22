using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project3_1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public ICollection<Quotation> Quotations { get; set; }
    }
}
