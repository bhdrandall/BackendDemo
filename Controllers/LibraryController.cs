using Microsoft.AspNetCore.Mvc;
using BackendDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        // Inject the DbContext through constructor
        public LibraryController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: api/library
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                var books = await _context.Books.ToListAsync();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/library
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] BookCreateRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Name))
                {
                    return BadRequest("Book name is required");
                }

                var book = new Book
                {
                    Name = request.Name
                };

                await _context.Books.AddAsync(book);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

    public class BookCreateRequest
    {
        public string Name { get; set; }
    }
}