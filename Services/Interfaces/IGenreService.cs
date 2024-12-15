using BackendDemo.Data.Entities;
using BackendDemo.Models;

namespace BackendDemo.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetGenresAsync();
        Task<Genre> AddGenreAsync(GenreCreateRequest request);
    }
}