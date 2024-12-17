using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendDemo.Data;
using BackendDemo.Models;
using Microsoft.EntityFrameworkCore;
using BackendDemo.Services.Interfaces;

namespace BackendDemo.Services
{
    public class UserService : IUserService
    {
        private readonly LibraryDbContext _context;
    
        public UserService(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            return await _context.Users
                .Select(user => new UserDto
                {
                    Id = user.Id.ToString(),
                    UserName = user.Username,
                    Role = user.Role.Name
                })
                .ToListAsync();
        }

        public async Task DeleteUserAsync(string userId)
        {
            if (!int.TryParse(userId, out int id))
            {
                throw new Exception($"Invalid user ID format: {userId}");
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                throw new Exception($"User with ID {id} not found");
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
} 