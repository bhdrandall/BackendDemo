using BackendDemo.Models;
using BackendDemo.Data.Entities;

namespace BackendDemo.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooksAsync();
        Task<BookDto> AddBookAsync(BookCreateRequest request);
    }
}