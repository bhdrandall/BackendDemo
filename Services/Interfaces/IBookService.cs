using BackendDemo.Models;
using BackendDemo.Data.Entities;

namespace BackendDemo.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> AddBookAsync(BookCreateRequest request);
    }
}