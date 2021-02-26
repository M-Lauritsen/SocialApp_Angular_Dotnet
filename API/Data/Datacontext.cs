using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        
    }
}