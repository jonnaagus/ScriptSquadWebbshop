using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptSquadWebbshop.Migrations
{
    /// <inheritdoc />
    public partial class changenametableproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c047536-998d-4509-9c19-d1e88253f242",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aec9b72e-6437-4342-a867-bf4d8059b48b", "AQAAAAIAAYagAAAAENv4H7gSqIJP4c3qhxeglPpZ0VRGd6iu3MVxEW3zVO797/YxYs6/Emi8VoGy41RX5Q==", "3eec14b8-3e51-4779-a58d-303d5a6c6839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4028df22-8f69-48cc-ac21-6bacd405582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a54b108b-83e1-43bc-9a7b-b73d905cc388", "AQAAAAIAAYagAAAAEAtIMo1n2T6f03vXD+Tr92kwNTCzb2qA94yes7oOArFKKj1ZyEJlZa2pE7uEZbE+HA==", "a40815b3-3d2e-47a4-ad5e-632496f674e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52dc88c3-8df2-45ac-ab72-9531a00a1dfe", "AQAAAAIAAYagAAAAEMsI+QZa4nkl16vQKTvvG3lyDsHMrmDZiQJJ3hl5tZDUhBrztoeo6B2jWmoWKICrnQ==", "fb36d674-551a-405c-a1d9-d1dacbc37c95" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
