using Microsoft.EntityFrameworkCore;

namespace Project3_1.Models
{
    public class Project3_1Context : DbContext
    {
        public Project3_1Context(DbContextOptions<Project3_1Context> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<QuotationProduct> QuotationProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuotationProduct>()
                .HasKey(qp => new { qp.QuotationId, qp.ProductId });

            modelBuilder.Entity<QuotationProduct>()
                .HasOne(qp => qp.Quotation)
                .WithMany(q => q.QuotationProducts)
                .HasForeignKey(qp => qp.QuotationId);

            modelBuilder.Entity<QuotationProduct>()
                .HasOne(qp => qp.Product)
                .WithMany()
                .HasForeignKey(qp => qp.ProductId);
        }
    }
}
