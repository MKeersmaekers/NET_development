using Microsoft.EntityFrameworkCore;
using MyFarm.Models;

namespace MyFarm.Data
{
    public class AnimalDbContext : DbContext
    {
        public AnimalDbContext(DbContextOptions<AnimalDbContext> options) : base(options)
        {

        }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().ToTable(nameof(Animal));
        }
    }

}
