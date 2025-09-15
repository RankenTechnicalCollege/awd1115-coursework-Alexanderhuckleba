using System.ComponentModel.DataAnnotations;

namespace HOT1.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 1000, ErrorMessage = "Quantity must be at least 1.")]
        public int? Quantity { get; set; }

        public string DiscountCode { get; set; }

        public decimal ShirtPrice => 15m;
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string ErrorMessage { get; set; }
    }
}
