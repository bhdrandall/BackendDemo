using BackendDemo.Data.Entities;
using BackendDemo.Models;

namespace BackendDemo.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetGenresAsync();
        Task<GenreDto> GetGenreAsync(int id);
        Task<GenreDto> AddGenreAsync(GenreCreateRequest request);
        Task UpdateGenreAsync(GenreDto genreDto);
        Task DeleteGenreAsync(int id);
    }
}