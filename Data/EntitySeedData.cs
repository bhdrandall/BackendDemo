using BackendDemo.Data.Entities;
using Microsoft.EntityFrameworkCore;

public class EntitySeedData
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
    // Seed Genres
    modelBuilder.Entity<Genre>().HasData(
        new Genre { Id = 1, Name = "Fiction" },
        new Genre { Id = 2, Name = "Science Fiction" },
        new Genre { Id = 3, Name = "Mystery" },
        new Genre { Id = 4, Name = "Romance" },
        new Genre { Id = 5, Name = "Fantasy" },
        new Genre { Id = 6, Name = "Non-Fiction" },
        new Genre { Id = 7, Name = "Thriller" },
        new Genre { Id = 8, Name = "Historical Fiction" }
    );

    // Seed Books
    modelBuilder.Entity<Book>().HasData(
        new Book
        {
            Id = 1,
            Name = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Description = "A story of the fabulously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 2,
            Name = "1984",
            Author = "George Orwell",
            Description = "A dystopian social science fiction novel that follows the life of Winston Smith.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 3,
            Name = "Pride and Prejudice",
            Author = "Jane Austen",
            Description = "A romantic novel following the character development of Elizabeth Bennet.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 4,
            Name = "The Hobbit",
            Author = "J.R.R. Tolkien",
            Description = "A fantasy novel about the adventures of Bilbo Baggins.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 5,
            Name = "To Kill a Mockingbird",
            Author = "Harper Lee",
            Description = "A novel about racial injustice and the loss of innocence in the American South.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 6,
            Name = "Dune",
            Author = "Frank Herbert",
            Description = "A science fiction masterpiece about politics, religion, and power in a desert world.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 7,
            Name = "The Da Vinci Code",
            Author = "Dan Brown",
            Description = "A thriller involving a conspiracy within the Catholic Church.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 8,
            Name = "The Catcher in the Rye",
            Author = "J.D. Salinger",
            Description = "A story of teenage alienation and loss of innocence in America.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 9,
            Name = "The Alchemist",
            Author = "Paulo Coelho",
            Description = "A philosophical novel about following one's dreams.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        },
        new Book
        {
            Id = 10,
            Name = "Sapiens",
            Author = "Yuval Noah Harari",
            Description = "A brief history of humankind exploring the evolution of human societies.",
            Owner = "Library",
            CheckedOutAt = DateTime.MinValue,
            DueDate = DateTime.MinValue,
            ReturnedAt = DateTime.MinValue
        }
    );

    // Seed the many-to-many relationship between Books and Genres
    modelBuilder.Entity("BookGenre").HasData(
        new { BooksId = 1, GenresId = 1 },  // The Great Gatsby - Fiction
        new { BooksId = 1, GenresId = 8 },  // The Great Gatsby - Historical Fiction
        
        new { BooksId = 2, GenresId = 1 },  // 1984 - Fiction
        new { BooksId = 2, GenresId = 2 },  // 1984 - Science Fiction
        
        new { BooksId = 3, GenresId = 1 },  // Pride and Prejudice - Fiction
        new { BooksId = 3, GenresId = 4 },  // Pride and Prejudice - Romance
        
        new { BooksId = 4, GenresId = 1 },  // The Hobbit - Fiction
        new { BooksId = 4, GenresId = 5 },  // The Hobbit - Fantasy
        
        new { BooksId = 5, GenresId = 1 },  // To Kill a Mockingbird - Fiction
        new { BooksId = 5, GenresId = 8 },  // To Kill a Mockingbird - Historical Fiction
        
        new { BooksId = 6, GenresId = 1 },  // Dune - Fiction
        new { BooksId = 6, GenresId = 2 },  // Dune - Science Fiction
        
        new { BooksId = 7, GenresId = 1 },  // The Da Vinci Code - Fiction
        new { BooksId = 7, GenresId = 7 },  // The Da Vinci Code - Thriller
        new { BooksId = 7, GenresId = 3 },  // The Da Vinci Code - Mystery
        
        new { BooksId = 8, GenresId = 1 },  // The Catcher in the Rye - Fiction
        
        new { BooksId = 9, GenresId = 1 },  // The Alchemist - Fiction
        new { BooksId = 9, GenresId = 5 },  // The Alchemist - Fantasy
        
        new { BooksId = 10, GenresId = 6 }  // Sapiens - Non-Fiction
        );
    }
}