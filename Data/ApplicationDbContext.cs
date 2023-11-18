using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace kme.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Models.UserDetailsEntity> UserDetails { get; set; }

    }
}
