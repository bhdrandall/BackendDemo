using Microsoft.EntityFrameworkCore;

namespace BackendDemo.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        // Add DbSet properties for your models
        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
