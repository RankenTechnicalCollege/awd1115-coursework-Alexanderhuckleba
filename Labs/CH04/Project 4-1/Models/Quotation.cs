namespace Project_4_1.Models
{
    public class Quotation
    {
        public decimal? Subtotal { get; set; }
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount =>
            (Subtotal.HasValue && DiscountPercent.HasValue)
                ? Subtotal.Value * (DiscountPercent.Value / 100m)
                : 0m;

        public decimal Total =>
            (Subtotal ?? 0m) - DiscountAmount;
    }
}
