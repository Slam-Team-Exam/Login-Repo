using Login_System.Entities;
using Login_System.Models;

namespace Login_System.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<string?> LoginAsync(UserDTO request);
    }
}
