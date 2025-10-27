namespace Login_System.Models
{
    public class RefreshTokenRequestDto
    {
        public Guid UserId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
