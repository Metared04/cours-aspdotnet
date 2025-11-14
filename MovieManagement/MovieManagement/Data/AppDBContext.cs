using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Areas.Identity.Data;
using MovieManagement.Models.Entities;

namespace MovieManagement.Data
{
    public class AppDBContext : IdentityDbContext<MovieManagementUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
