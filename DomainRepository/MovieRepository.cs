using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly FinalProjectContext _context;

        public MovieRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async void Delete(Movie entity)
        {
            var user = await _context.Movies.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Movies.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> Get(int id)
        {
            return await _context.Movies.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Rate> GetRate(int id)
        {
            return new Rate { Id = id, Rating = await _context.Reviews.Where(r => r.MovieId == id).AverageAsync(r => r.Rate) };
        }

        public async void Insert(Movie entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(Movie entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
