namespace FinalProjCH2.Models
{
    public class Quotation
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
