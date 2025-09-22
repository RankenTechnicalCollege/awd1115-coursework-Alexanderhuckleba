using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project3_1.Models
{
    public class Quotation
    {
        [Key]
        public int QuotationId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }

        public ICollection<QuotationProduct> QuotationProducts { get; set; }
    }
}
