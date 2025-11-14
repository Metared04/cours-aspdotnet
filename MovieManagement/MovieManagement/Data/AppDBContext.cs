using Microsoft.EntityFrameworkCore;
using MovieManagement.Models.Entities;

namespace MovieManagement.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
