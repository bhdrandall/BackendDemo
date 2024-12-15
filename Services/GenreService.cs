using BackendDemo.Data;
using BackendDemo.Data.Entities;
using BackendDemo.Models;
using BackendDemo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendDemo.Services
{
    public class GenreService : IGenreService
    {
        private readonly LibraryDbContext _context;

        public GenreService(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await _context.Genres
                .Include(g => g.Books)
                .ToListAsync();
        }

        public async Task<Genre> AddGenreAsync(GenreCreateRequest request)
        {
            var genre = new Genre
            {
                Name = request.Name
            };

            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();

            return genre;
        }
    }
}