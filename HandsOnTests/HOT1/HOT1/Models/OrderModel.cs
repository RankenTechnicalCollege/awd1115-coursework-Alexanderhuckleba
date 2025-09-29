using System.ComponentModel.DataAnnotations;

namespace HOT1.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 1000, ErrorMessage = "Quantity must be at least 1.")]
        public int? Quantity { get; set; }

        [Display(Name = "Discount Code (optional)")]
        public string DiscountCode { get; set; }

        public double ShirtPrice => 15;
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public string ErrorMessage { get; set; }

        public void CalculateTotal()
        {
            double discountPercent = 0;

            if (!string.IsNullOrEmpty(DiscountCode))
            {
                switch (DiscountCode.Trim())
                {
                    case "6175": discountPercent = 0.30; break;
                    case "1390": discountPercent = 0.20; break;
                    case "BB88": discountPercent = 0.10; break;
                    default:
                        ErrorMessage = "Invalid discount code. No discount applied.";
                        discountPercent = 0;
                        break;
                }
            }

            Subtotal = Quantity.Value * ShirtPrice * (1 - discountPercent);
            Tax = Subtotal * 0.08;
            Total = Subtotal + Tax;
        }
    }
}
