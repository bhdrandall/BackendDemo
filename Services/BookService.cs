using BackendDemo.Data;
using BackendDemo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BackendDemo.Services.Interfaces;
using BackendDemo.Models;

namespace BackendDemo.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext _context;

        public BookService(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _context.Books
                .Include(b => b.Genres)
                .ToListAsync();
        }

        public async Task<Book> AddBookAsync(BookCreateRequest request)
        {
            var book = new Book
            {
                Name = request.Name,
                Author = request.Author,
                Description = request.Description,
                Owner = request.Owner,
                CheckedOutAt = DateTime.MinValue,
                DueDate = DateTime.MinValue,
                ReturnedAt = DateTime.MinValue
            };

            if (request.GenreIds != null && request.GenreIds.Any())
            {
                var genres = await _context.Genres
                    .Where(g => request.GenreIds.Contains(g.Id))
                    .ToListAsync();
                foreach (var genre in genres)
                {
                    book.Genres.Add(genre);
                }
            }

            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return book;
        }
    }
}
