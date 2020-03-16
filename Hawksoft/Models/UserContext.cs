using Microsoft.EntityFrameworkCore;

namespace Hawksoft.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        { }
        public DbSet<UserViewModel> Users { get; set; }
    }
}
