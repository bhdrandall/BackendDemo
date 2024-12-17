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

        public async Task<IEnumerable<GenreDto>> GetGenresAsync()
        {
            var genres = await _context.Genres
                .Include(g => g.Books)
                .ToListAsync();

            return genres.Select(g => new GenreDto
            {
                Id = g.Id,
                Name = g.Name
            });
        }

        public async Task<GenreDto> GetGenreAsync(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
                throw new Exception("Genre not found");

            return new GenreDto { Id = genre.Id, Name = genre.Name };
        }

        public async Task<GenreDto> AddGenreAsync(GenreCreateRequest request)
        {
            var genre = new Genre
            {
                Name = request.Name
            };

            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();

            return new GenreDto
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public async Task UpdateGenreAsync(GenreDto genreDto)
        {
            var genre = await _context.Genres.FindAsync(genreDto.Id);
            if (genre == null)
                throw new Exception("Genre not found");

            genre.Name = genreDto.Name;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGenreAsync(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
                throw new Exception("Genre not found");

            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }
    }
}