using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptSquadWebbshop.Migrations
{
    /// <inheritdoc />
    public partial class mvc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "Purchases",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c047536-998d-4509-9c19-d1e88253f242",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db3457e7-d7ba-4093-80e6-b4282a316574", "AQAAAAIAAYagAAAAEEU7himgLPUH1lsGfkVrKzoxCGxB9seauVEOU4kq7klB7+5htUS1IV7V8tfo5Bl6Nw==", "a4d44639-71be-4e3d-a7b3-95d76447ec54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4028df22-8f69-48cc-ac21-6bacd405582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "483c2d0b-d003-4768-a042-c9c90cf8bd21", "AQAAAAIAAYagAAAAENUKNae8LKx+O/AL/4F9hJClBSDD9DA57if9OCfv5jrhViB+dv3sS/mLMMYowV9uuA==", "dffe2ef9-460e-4625-a6ae-073234c28c8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb050a20-b1ba-4f6b-b8f0-c4ed65957c55", "AQAAAAIAAYagAAAAEBc9xpPknPFhXzoIajaNJhAHBI2apJwk3zqI5HEdeS+doeZI6tHN4L5+tK1ujSBk4Q==", "f1c52c5f-f6ad-42b6-a97a-e8fe9196a4f9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Purchases",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
        }
    }
}
