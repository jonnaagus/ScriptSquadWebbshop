using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScriptSquadWebbshop.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "0c047536-998d-4509-9c19-d1e88253f242", 0, "Testargatan 1", "Testarstan", "e87f9022-5f78-4d4c-9a6b-98aca9cf04ed", "test@mail.co", true, "Test", "Testsson", false, null, "TEST@MAIL.COM", "TEST@MAIL.COM", "AQAAAAIAAYagAAAAEJYj+11DX8vKOCWl/bhiPfOIQUKo5O33JPjkoqL++NVjsQdpKd1YpQsJjjbXPFkc2A==", "123456", false, "b9806e91-9721-442d-aece-8fc6c426adf8", false, "test@mail.com", 11123 },
                    { "4028df22-8f69-48cc-ac21-6bacd405582e", 0, "Testargatan 1", "Testarstan", "1384b702-3c1b-4dea-9948-7b5e0b089505", "tes2t@mail.co", true, "Test2", "Testsson", false, null, "TEST2@MAIL.COM", "TEST2@MAIL.COM", "AQAAAAIAAYagAAAAEF3JvoVI/sC5zBfb56pVX0qs0SiOPr7J9MwqbqHjopeTqpMwrEQALMlD7LlMbEYfzQ==", "123456", false, "e6279125-be0f-4aca-8cc5-4b31c17ef68d", false, "test2@mail.com", 11123 },
                    { "b01e3f0d-acb0-4eab-90b3-8a519e3456b9", 0, "Testargatan 1", "Testarstan", "0dd1b013-8219-447e-b8b7-01014fe3a5af", "test1@mail.co", true, "Test1", "Testsson", false, null, "TEST1@MAIL.COM", "TEST1@MAIL.COM", "AQAAAAIAAYagAAAAEJA+vJHrtw4tA23KOLOKLYtLoptZvHzF7nkbJwPahEn4Mz3G2q4Y559glO+NOCgo3w==", "123456", false, "3120cfce-f7e8-4200-989b-3046ffb15856", false, "test1@mail.com", 11123 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 100, "Apple TV 4K (2022) – all underhållning på ett ställe med skarp bild, tillgång till appar, filmer, musik och spel och en ännu mer lättanvänd fjärrkontroll.", "/images/appletv.jpg", 1995f, "Apple TV", 5 },
                    { 102, "Electrolux Pure 300 luftrenare erbjuder avancerad luftrening för hem upp till 46 m². Med dess smarta design och kraftfulla filtreringssystem andas du renare och friskare luft varje dag.", "/images/luftrenare.jpg", 1499f, "Electrolux luftrenare", 1 },
                    { 103, "Rena luften tyst och effektivt i små rum som sovrum eller i en liten lägenhet. Svensktillverkade Woods AL310 luftrenare med joniserande filtreringsteknologi tar bort 99,98 procent av alla skadliga partiklar. För rum upp till 55 kvm.", "/images/luftrenare1.jpg", 4990f, "Woods luftrenare", 3 },
                    { 104, "TP-Link Deco BE65 är en avancerad mesh-router som levererar blixtsnabba hastigheter och stabil uppkoppling i hela hemmet. Med WiFi 7 är du rustad för framtidens internethastigheter.", "/images/router.jpg", 6490f, "TP-Link router", 7 },
                    { 105, "Asus RT-AX53U är en högpresterande router med stöd för framtidens trådlösa standard (WiFi 6). Upp till 1,8 Gbps hastighet, hög säkerhet med inbyggt virussystem och föräldrakontroll.", "/images/router1.jpg", 849f, "Asus router", 5 },
                    { 106, "Starlink Business High Performance kit – koppla upp företaget eller användare med höga krav till ett snabbt och pålitligt internet 24/7. Med Starlink Business har du alltid bästa prestanda oavsett belastningen på nätverket. (Abonnemang krävs och säljs separat.)", "/images/routerkit.jpg", 27999f, "Starlink router", 2 },
                    { 107, "Nexa MYC-4 plug-in-kit med fjärrkontroll och 3 trådlösa plug-in-mottagare. Tänd och släck lampor hemma med fjärrkontroll. Plugga in i vägguttaget och anslut lampans stickpropp.", "/images/uttag.jpg", 199.9f, "Nexa fjärrströmbrytare", 5 },
                    { 108, "Yale Doorman L3S Flex är det digitala dörrlåset som gör livet enklare. Lås upp med kod, nyckeltag, app eller låt låset låsa upp dörren åt dig med hjälp av geofencing. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare.", "/images/yale.jpg", 5990f, "Yale Doorman L3S", 7 },
                    { 109, "Yale Doorman Classic digitalt lås – lås upp med sifferkod, nyckeltagg eller en kombination av båda. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare. Upp till 10 nyckelbrickor och upp till 10 unika användarkoder. Låsklass 2A.", "/images/yale1.jpg", 3499f, "Yale Doorman Classic", 12 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { 100, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0c047536-998d-4509-9c19-d1e88253f242" },
                    { 101, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "b01e3f0d-acb0-4eab-90b3-8a519e3456b9" },
                    { 102, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4028df22-8f69-48cc-ac21-6bacd405582e" },
                    { 103, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4028df22-8f69-48cc-ac21-6bacd405582e" },
                    { 104, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b01e3f0d-acb0-4eab-90b3-8a519e3456b9" },
                    { 105, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0c047536-998d-4509-9c19-d1e88253f242" }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "ProductOrderId", "Amount", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 100, 1, 100, 100 },
                    { 101, 2, 101, 102 },
                    { 102, 2, 102, 109 },
                    { 103, 1, 103, 105 },
                    { 104, 5, 104, 102 },
                    { 105, 2, 104, 103 },
                    { 106, 3, 105, 100 },
                    { 107, 1, 105, 107 },
                    { 108, 1, 105, 102 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "ProductOrderId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c047536-998d-4509-9c19-d1e88253f242");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4028df22-8f69-48cc-ac21-6bacd405582e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b01e3f0d-acb0-4eab-90b3-8a519e3456b9");
        }
    }
}
