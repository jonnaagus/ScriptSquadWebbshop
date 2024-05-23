using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ScriptSquadWebbshop.Models;

namespace ScriptSquadWebbshop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Procuct { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(
                new Product { ProductId = 100, ProductName = "Apple TV", Description = "Apple TV 4K (2022) – all underhållning på ett ställe med skarp bild, tillgång till appar, filmer, musik och spel och en ännu mer lättanvänd fjärrkontroll.", Price = 1995.00f, Quantity = 5, ImageUrl = "/images/appletv.jpg" },
                new Product { ProductId = 102, ProductName = "Electrolux luftrenare", Description = "Electrolux Pure 300 luftrenare erbjuder avancerad luftrening för hem upp till 46 m². Med dess smarta design och kraftfulla filtreringssystem andas du renare och friskare luft varje dag.", Price = 1499.00f, Quantity = 1, ImageUrl = "/images/luftrenare.jpg" },
                new Product { ProductId = 103, ProductName = "Woods luftrenare", Description = "Rena luften tyst och effektivt i små rum som sovrum eller i en liten lägenhet. Svensktillverkade Woods AL310 luftrenare med joniserande filtreringsteknologi tar bort 99,98 procent av alla skadliga partiklar. För rum upp till 55 kvm.", Price = 4990.00f, Quantity = 3, ImageUrl = "/images/luftrenare1.jpg" },
                new Product { ProductId = 104, ProductName = "TP-Link router", Description = "TP-Link Deco BE65 är en avancerad mesh-router som levererar blixtsnabba hastigheter och stabil uppkoppling i hela hemmet. Med WiFi 7 är du rustad för framtidens internethastigheter.", Price = 6490.00f, Quantity = 7, ImageUrl = "/images/router.jpg" },
                new Product { ProductId = 105, ProductName = "Asus router", Description = "Asus RT-AX53U är en högpresterande router med stöd för framtidens trådlösa standard (WiFi 6). Upp till 1,8 Gbps hastighet, hög säkerhet med inbyggt virussystem och föräldrakontroll.", Price = 849.00f, Quantity = 5, ImageUrl = "/images/router1.jpg" },
                new Product { ProductId = 106, ProductName = "Starlink router", Description = "Starlink Business High Performance kit – koppla upp företaget eller användare med höga krav till ett snabbt och pålitligt internet 24/7. Med Starlink Business har du alltid bästa prestanda oavsett belastningen på nätverket. (Abonnemang krävs och säljs separat.)", Price = 27999.00f, Quantity = 2, ImageUrl = "/images/routerkit.jpg" },
                new Product { ProductId = 107, ProductName = "Nexa fjärrströmbrytare", Description = "Nexa MYC-4 plug-in-kit med fjärrkontroll och 3 trådlösa plug-in-mottagare. Tänd och släck lampor hemma med fjärrkontroll. Plugga in i vägguttaget och anslut lampans stickpropp.", Price = 199.90f, Quantity = 5, ImageUrl = "/images/uttag.jpg" },
                new Product { ProductId = 108, ProductName = "Yale Doorman L3S", Description = "Yale Doorman L3S Flex är det digitala dörrlåset som gör livet enklare. Lås upp med kod, nyckeltag, app eller låt låset låsa upp dörren åt dig med hjälp av geofencing. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare.", Price = 5990.00f, Quantity = 7, ImageUrl = "/images/yale.jpg" },
                new Product { ProductId = 109, ProductName = "Yale Doorman Classic", Description = "Yale Doorman Classic digitalt lås – lås upp med sifferkod, nyckeltagg eller en kombination av båda. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare. Upp till 10 nyckelbrickor och upp till 10 unika användarkoder. Låsklass 2A.", Price = 3499.00f, Quantity = 12, ImageUrl = "/images/yale1.jpg" }
            );

            PasswordHasher<User> ph = new PasswordHasher<User>();

            //create users
            var user = new User
            {
                Id = "0c047536-998d-4509-9c19-d1e88253f242",
                UserName = "test@mail.com",
                NormalizedUserName = "TEST@MAIL.COM",
                NormalizedEmail = "TEST@MAIL.COM",
                Email = "test@mail.co",
                EmailConfirmed = true,
                PhoneNumber = "123456",
                Address = "Testargatan 1",
                City = "Testarstan",
                FirstName = "Test",
                LastName = "Testsson",
                ZipCode = 11123,

            };
            user.PasswordHash = ph.HashPassword(user, "Test123!");
            builder.Entity<User>().HasData(user);

            user = new User
            {
                Id = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                UserName = "test1@mail.com",
                NormalizedUserName = "TEST1@MAIL.COM",
                NormalizedEmail = "TEST1@MAIL.COM",
                Email = "test1@mail.co",
                EmailConfirmed = true,
                PhoneNumber = "123456",
                Address = "Testargatan 1",
                City = "Testarstan",
                FirstName = "Test1",
                LastName = "Testsson",
                ZipCode = 11123,

            };
            user.PasswordHash = ph.HashPassword(user, "Test123!");
            builder.Entity<User>().HasData(user);

            user = new User
            {
                Id = "4028df22-8f69-48cc-ac21-6bacd405582e",
                UserName = "test2@mail.com",
                NormalizedUserName = "TEST2@MAIL.COM",
                NormalizedEmail = "TEST2@MAIL.COM",
                Email = "tes2t@mail.co",
                EmailConfirmed = true,
                PhoneNumber = "123456",
                Address = "Testargatan 1",
                City = "Testarstan",
                FirstName = "Test2",
                LastName = "Testsson",
                ZipCode = 11123,

            };
            user.PasswordHash = ph.HashPassword(user, "Test123!");
            builder.Entity<User>().HasData(user);

            builder.Entity<Order>().HasData(
                new Order { OrderId=100, UserId= "0c047536-998d-4509-9c19-d1e88253f242", OrderDate= new DateTime(2024,04,20)},
                new Order { OrderId = 101, UserId = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9", OrderDate = new DateTime(2024,05,20) },
                new Order { OrderId = 102, UserId = "4028df22-8f69-48cc-ac21-6bacd405582e", OrderDate = new DateTime(2024,04,21) },
                new Order { OrderId = 103, UserId = "4028df22-8f69-48cc-ac21-6bacd405582e", OrderDate = new DateTime(2024,04,21) },
                new Order { OrderId = 104, UserId = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9", OrderDate = new DateTime(2024,05,01) },
                new Order { OrderId = 105, UserId = "0c047536-998d-4509-9c19-d1e88253f242", OrderDate = new DateTime(2024,05,05) }
                );

            builder.Entity<ProductOrder>().HasData(
                new ProductOrder { ProductOrderId = 100, ProductId = 100, OrderId = 100, Amount = 1 },
                new ProductOrder { ProductOrderId = 101, ProductId = 102, OrderId = 101, Amount = 2 },
                new ProductOrder { ProductOrderId = 102, ProductId = 109, OrderId = 102, Amount = 2 },
                new ProductOrder { ProductOrderId = 103, ProductId = 105, OrderId = 103, Amount = 1 },
                new ProductOrder { ProductOrderId = 104, ProductId = 102, OrderId = 104, Amount = 5 },
                new ProductOrder { ProductOrderId = 105, ProductId = 103, OrderId = 104, Amount = 2 },
                new ProductOrder { ProductOrderId = 106, ProductId = 100, OrderId = 105, Amount = 3 },
                new ProductOrder { ProductOrderId = 107, ProductId = 107, OrderId = 105, Amount = 1 },
                new ProductOrder { ProductOrderId = 108, ProductId = 102, OrderId = 105, Amount = 1 }
                );


        }

    }
}
