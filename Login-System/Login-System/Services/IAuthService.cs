using Login_System.Entities;
using Login_System.Models;

namespace Login_System.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(UserDTO request);      // true/false om det lykkedes
        Task<string?> LoginAsync(UserDTO request);      // JWT token eller null
    }
}
