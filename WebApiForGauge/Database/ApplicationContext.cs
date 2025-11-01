using WebApiForGauge.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiForGauge.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<WorkoutProgram> Programs { get; set; }
        public DbSet<WorkoutDay> WorkoutDays { get; set; }
        public DbSet<PhysicalExercises> PhysicalExercises { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutDay>().HasKey(d => d.Number);
            base.OnModelCreating(modelBuilder);
        }
    }
}
