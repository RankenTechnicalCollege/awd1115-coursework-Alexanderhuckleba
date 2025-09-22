using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_3_1.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerToQuotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotationProducts",
                table: "QuotationProducts");

            migrationBuilder.AddColumn<int>(
                name: "QuotationProductId",
                table: "QuotationProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotationProducts",
                table: "QuotationProducts",
                column: "QuotationProductId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationProducts_QuotationId",
                table: "QuotationProducts",
                column: "QuotationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotationProducts",
                table: "QuotationProducts");

            migrationBuilder.DropIndex(
                name: "IX_QuotationProducts_QuotationId",
                table: "QuotationProducts");

            migrationBuilder.DropColumn(
                name: "QuotationProductId",
                table: "QuotationProducts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotationProducts",
                table: "QuotationProducts",
                columns: new[] { "QuotationId", "ProductId" });
        }
    }
}
