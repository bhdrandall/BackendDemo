using BackendDemo.Data;
using BackendDemo.Data.Entities;
using BackendDemo.Models;
using BackendDemo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BackendDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/genre
        [HttpGet]
        public async Task<IActionResult> GetGenres()
        {
            try
            {
                var genres = await _genreService.GetGenresAsync();
                return Ok(genres);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/genre
        [HttpPost]
        public async Task<IActionResult> AddGenre([FromBody] GenreCreateRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Name))
                {
                    return BadRequest("Genre name is required");
                }

                var genre = await _genreService.AddGenreAsync(request);

                return CreatedAtAction(nameof(GetGenres),
                    new { id = genre.Id },
                    genre);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}