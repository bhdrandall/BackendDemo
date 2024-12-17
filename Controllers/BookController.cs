using BackendDemo.Data;
using BackendDemo.Data.Entities;
using BackendDemo.Models;
using BackendDemo.Services;
using BackendDemo.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BackendDemo.Data.Enums;

namespace BackendDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/book
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                var isAuthenticated = User.Identity.IsAuthenticated;
                var userRole = User.FindFirst(ClaimTypes.Role)?.Value;

                Console.WriteLine($"IsAuthenticated: {isAuthenticated}");
                Console.WriteLine($"User Role: {userRole}");

                if (!isAuthenticated)
                {
                    return Unauthorized("User is not authenticated");
                }

                var books = await _bookService.GetBooksAsync(userRole);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/book/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            try
            {
                var userRole = User.FindFirst(ClaimTypes.Role)?.Value;
                var book = await _bookService.GetBookAsync(id, userRole);
                
                if (book == null)
                    return NotFound();

                return Ok(book);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/book/genre/{genreId}
        [HttpGet("genre/{genreId}")]
        public async Task<IActionResult> GetBooksByGenre(int genreId)
        {
            try
            {
                var books = await _bookService.GetBooksByGenreAsync(genreId);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/book
        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult>
        AddBook([FromBody] BookCreateRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Name))
                {
                    return BadRequest("Book name is required");
                }

                var book = await _bookService.AddBookAsync(request);

                return CreatedAtAction(nameof(GetBooks),
                new { id = book.Id },
                book);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // Update a book
        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody] BookDto updatedBook)
        {
            try
            {
                await _bookService.UpdateBookAsync(updatedBook);

                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // Delete a book
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                await _bookService.DeleteBookAsync(id);

                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
