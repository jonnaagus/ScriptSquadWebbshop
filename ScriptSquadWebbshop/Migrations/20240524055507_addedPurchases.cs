using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptSquadWebbshop.Migrations
{
    /// <inheritdoc />
    public partial class addedPurchases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_Purchases_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c047536-998d-4509-9c19-d1e88253f242",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d98be3fe-89e5-43a6-b40a-5cb62ced8f26", "AQAAAAIAAYagAAAAEHz6D5PkuxWvVuTYuRltDmTNT0IuIH/4X1sEN7h1cvukhyg6bNWtC8P+aFgRXDN7uw==", "3da6786a-5bf4-49a3-a5f9-5716e9f872ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4028df22-8f69-48cc-ac21-6bacd405582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09520ed2-2dd3-463f-9a7b-dd512c4826d2", "AQAAAAIAAYagAAAAEFrxo60da4ngjGx0+Yr5GHXG4yXImmp9o23WdFgj1qSfBk0QOAcGTv7gVt9Qt3MrfQ==", "4cb53a88-ab05-4088-b300-80ef4b848b19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17db0f69-d0d4-4a22-b08b-4bae04439724", "AQAAAAIAAYagAAAAEC+wiHQfSUEIq9i7ICYYunoUwy9hbHhJt3wrQJxhPEwsMu10fByrb59Y40pRGq5FPQ==", "e8e3eea5-f24a-4036-966a-4044e679c12a" });

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProductId",
                table: "Purchases",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c047536-998d-4509-9c19-d1e88253f242",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e87f9022-5f78-4d4c-9a6b-98aca9cf04ed", "AQAAAAIAAYagAAAAEJYj+11DX8vKOCWl/bhiPfOIQUKo5O33JPjkoqL++NVjsQdpKd1YpQsJjjbXPFkc2A==", "b9806e91-9721-442d-aece-8fc6c426adf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4028df22-8f69-48cc-ac21-6bacd405582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1384b702-3c1b-4dea-9948-7b5e0b089505", "AQAAAAIAAYagAAAAEF3JvoVI/sC5zBfb56pVX0qs0SiOPr7J9MwqbqHjopeTqpMwrEQALMlD7LlMbEYfzQ==", "e6279125-be0f-4aca-8cc5-4b31c17ef68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd1b013-8219-447e-b8b7-01014fe3a5af", "AQAAAAIAAYagAAAAEJA+vJHrtw4tA23KOLOKLYtLoptZvHzF7nkbJwPahEn4Mz3G2q4Y559glO+NOCgo3w==", "3120cfce-f7e8-4200-989b-3046ffb15856" });
        }
    }
}
