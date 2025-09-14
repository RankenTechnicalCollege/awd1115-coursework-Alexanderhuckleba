namespace project_3_1.Models
{
    public class QuotationViewModel
    {
        public decimal? Subtotal { get; set; }
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount =>
            (Subtotal.HasValue && DiscountPercent.HasValue)
                ? Subtotal.Value * (DiscountPercent.Value / 100)
                : 0;

        public decimal Total =>
            (Subtotal.HasValue)
                ? Subtotal.Value - DiscountAmount
                : 0;
    }
}
