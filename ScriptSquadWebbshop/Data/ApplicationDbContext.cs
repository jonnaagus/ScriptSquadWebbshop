using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScriptSquadWebbshop.Models;

namespace ScriptSquadWebbshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Procuct { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<User> User { get; set; }

    }
}
