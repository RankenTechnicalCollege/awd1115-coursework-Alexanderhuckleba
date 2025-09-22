using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project3_1.Models
{
    public class QuotationViewModel
    {
        public int QuotationId { get; set; }   // ✅ Add this for Edit/Delete

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal? Subtotal { get; set; }

        [Required]
        [Range(0.01, 100)]
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }

        // Selected Products (Many-to-Many)
        public List<int> SelectedProductIds { get; set; } = new List<int>();

        // Dropdown lists
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
