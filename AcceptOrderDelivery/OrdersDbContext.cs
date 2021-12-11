using AcceptOrderDelivery.Models;
using Microsoft.EntityFrameworkCore;

namespace AcceptOrderDelivery
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasKey(i => i.Id);
            modelBuilder.Entity<Order>().Property(i => i.SenderCity).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Order>().Property(i => i.SenderAddress).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Order>().Property(i => i.RecipientCity).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Order>().Property(i => i.RecipientAddress).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Order>().Property(i => i.Weight).IsRequired().HasPrecision(5, 2);
            modelBuilder.Entity<Order>().Property(i => i.Date).IsRequired();
            modelBuilder.Entity<Order>().Property(i => i.OrderNumber).IsRequired().HasMaxLength(6);
        }
    }
}
