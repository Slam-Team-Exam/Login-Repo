using Login_System.Entities;
using Login_System.Models;

namespace Login_System.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<TokenResponseDto?> LoginAsync(UserDTO request);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);

        
    }
}
