using Microsoft.EntityFrameworkCore;
using MPPIS.Models;

namespace MPPIS.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
    }
}
