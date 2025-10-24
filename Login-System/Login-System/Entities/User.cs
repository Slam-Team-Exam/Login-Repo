namespace Login_System.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; } = string.Empty;
        //hash pga passwordhash kommer til at være langt.
        public string PasswordHash { get; set; } = string.Empty;
    }
}
