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

        public async Task<IEnumerable<BookDto>> GetBooksAsync()
        {
            var books = await _context.Books
                .Include(b => b.Genres)
                .ToListAsync();

            return books.Select(b => new BookDto
            {
                Id = b.Id,
                Name = b.Name,
                Author = b.Author,
                Description = b.Description,
                Owner = b.Owner,
                CheckedOutAt = b.CheckedOutAt,
                DueDate = b.DueDate,
                ReturnedAt = b.ReturnedAt,
                Genres = b.Genres.Select(g => new GenreDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList()
            });
        }

        public async Task<IEnumerable<BookDto>> GetBooksByGenreAsync(int genreId)
        {
            var books = await _context.Books
                .Include(b => b.Genres)
                .Where(b => b.Genres.Any(g => g.Id == genreId))
                .ToListAsync();

            return books.Select(b => new BookDto
            {
                Id = b.Id,
                Name = b.Name,
                Author = b.Author,
                Description = b.Description,
                Owner = b.Owner,
                CheckedOutAt = b.CheckedOutAt,
                DueDate = b.DueDate,
                ReturnedAt = b.ReturnedAt,
                Genres = b.Genres.Select(g => new GenreDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList()
            });
        }

        public async Task<BookDto> GetBookByIdAsync(int id)
        {
            var book = await _context.Books
                .Include(b => b.Genres)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return null;

            return new BookDto
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Description = book.Description,
                Owner = book.Owner,
                CheckedOutAt = book.CheckedOutAt,
                DueDate = book.DueDate,
                ReturnedAt = book.ReturnedAt,
                Genres = book.Genres.Select(g => new GenreDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList()
            };
        }

        public async Task<BookDto> AddBookAsync(BookCreateRequest request)
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

            return new BookDto
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Description = book.Description,
                Owner = book.Owner,
                CheckedOutAt = book.CheckedOutAt,
                DueDate = book.DueDate,
                ReturnedAt = book.ReturnedAt,
                Genres = book.Genres.Select(g => new GenreDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList()
            };
        }
    }
}
