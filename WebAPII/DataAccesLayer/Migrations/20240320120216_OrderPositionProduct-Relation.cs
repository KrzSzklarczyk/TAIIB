using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class OrderPositionProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPosition_ProductId",
                table: "OrderPosition",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Product_ProductId",
                table: "OrderPosition",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Product_ProductId",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_OrderPosition_ProductId",
                table: "OrderPosition");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderPosition");
        }
    }
}
