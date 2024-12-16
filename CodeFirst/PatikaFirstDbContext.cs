using CodeFirst.Data.Entity;
using Microsoft.EntityFrameworkCore;
namespace CodeFirst
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAKICI53;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Game>().ToTable("Games");

        }
    }
}
