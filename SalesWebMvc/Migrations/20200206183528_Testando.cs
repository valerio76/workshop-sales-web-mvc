using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class Testando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Seller",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_ProductId",
                table: "Seller",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_ProductId",
                table: "SalesRecord",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DepartmentId",
                table: "Product",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Department_DepartmentId",
                table: "Product",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Product_ProductId",
                table: "SalesRecord",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Product_ProductId",
                table: "Seller",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Department_DepartmentId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Product_ProductId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Product_ProductId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_ProductId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_ProductId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_Product_DepartmentId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Product");
        }
    }
}
