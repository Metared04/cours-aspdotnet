using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using MovieManagement.Models.Entities;

namespace MovieManagement.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDBContext _context;
        public MovieService(AppDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var m = await _context.Movies.FindAsync(id);
            if (m != null)
            {
                _context.Movies.Remove(m);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Movie>> GetAllAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task UpdateAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }
    }
}
