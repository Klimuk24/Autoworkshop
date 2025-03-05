using Microsoft.EntityFrameworkCore;
using AutoWorkShop.Models;

namespace AutoWorkShop.Data
{
    public class AutoWorkshopContext : DbContext
    {
        public AutoWorkshopContext(DbContextOptions<AutoWorkshopContext> options) : base(options)
        {
        }

        // DbSet для каждой модели
        public DbSet<Master> Masters { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
