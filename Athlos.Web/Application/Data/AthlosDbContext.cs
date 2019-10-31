using Microsoft.EntityFrameworkCore;

namespace Athlos.Application.Data
{
    public class AthlosDbContext : DbContext
    {
        public DbSet<TrainingPlanEntity> TrainingPlans { get; set; }

        public AthlosDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainingPlanEntity>().ToTable("TrainingPlans");
        }
    }
}
