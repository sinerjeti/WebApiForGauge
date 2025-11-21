using WebApiForGauge.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiForGauge.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(u => u.Birthday)
                .HasColumnType("date");
        }
    }
}
