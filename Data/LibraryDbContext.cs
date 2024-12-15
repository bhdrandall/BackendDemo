using BackendDemo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendDemo.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) :
            base(options)
        {
        }

        // Add DbSet properties for your models
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Genres)
                .WithMany(g => g.Books);
        }
    }
}
