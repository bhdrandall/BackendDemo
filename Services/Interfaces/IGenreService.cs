using BackendDemo.Data.Entities;
using BackendDemo.Models;

namespace BackendDemo.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetGenresAsync();
        Task<GenreDto> AddGenreAsync(GenreCreateRequest request);
    }
}