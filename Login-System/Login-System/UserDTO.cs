namespace Login_System
{
    public class UserDTO
    {
        public string Username { get; set; } = string.Empty;
        //hash pga passwordhash kommer til at være langt.
        public string Password { get; set; } = string.Empty;
    }
}
