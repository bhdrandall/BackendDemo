using System.Collections.Generic;
using System.Threading.Tasks;
using BackendDemo.Models;

namespace BackendDemo.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task DeleteUserAsync(string userId);
    }
} 