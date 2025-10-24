using Login_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Login_System.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
