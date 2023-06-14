using Microsoft.EntityFrameworkCore;
using UnitTest_Demo.Model;

namespace UnitTest_Demo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public virtual DbSet<Manga> Mangas { get; set; }
        protected void OnModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manga>().HasData(
                    new Manga { Id = 1, Name = "Doraemon", Description = "For Children", price = 5 },
                    new Manga { Id = 2, Name = "Conan", Description = "For Teen", price = 6 }
                );
        }
    }
}

    
