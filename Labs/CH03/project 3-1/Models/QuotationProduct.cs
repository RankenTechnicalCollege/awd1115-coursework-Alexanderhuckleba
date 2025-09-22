namespace Project3_1.Models
{
    public class QuotationProduct
    {
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
