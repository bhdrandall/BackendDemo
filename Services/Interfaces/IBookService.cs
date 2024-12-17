using BackendDemo.Models;
using BackendDemo.Data.Entities;

namespace BackendDemo.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooksAsync(string userRole);
        Task<BookDto> GetBookAsync(int id, string userRole);
        Task<IEnumerable<BookDto>> GetBooksByGenreAsync(int genreId);
        Task<BookDto> AddBookAsync(BookCreateRequest request);
        Task UpdateBookAsync(BookDto bookDto);
        Task DeleteBookAsync(int id);
    }
}