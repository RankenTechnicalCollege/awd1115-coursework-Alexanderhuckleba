using System.ComponentModel.DataAnnotations;

namespace project_3_1.Models
{
    public class QuotationViewModel
    {
        [Required(ErrorMessage = "Subtotal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Subtotal must be greater than zero.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0.01, 100.00, ErrorMessage = "Discount percent must be between 0.01 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}
