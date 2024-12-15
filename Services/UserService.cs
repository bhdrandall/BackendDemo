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
    }
} 