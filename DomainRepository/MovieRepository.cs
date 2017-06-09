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

        public async Task<Movie> Delete(Movie entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Movie> Get(int id)
        {
            return await _context.Movies.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _context.Movies.Where(m => !m.IsDeleted).ToListAsync();
        }

        public async Task<Category> GetMovieCategory(int id)
        {
            return await _context.Movies.Select(m => m.Category).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Movie>> GetMoviesByCategory(int id)
        {
            return await _context.Movies.Where(m => m.CategoryId == id).ToListAsync();
        }

        public async Task<Rate> GetRate(int id)
        {
            return new Rate { Id = id, Rating = await _context.Reviews.Where(r => r.MovieId == id).AverageAsync(r => r.Rate) };
        }

        public async Task<Movie> Insert(Movie entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Movie> Update(Movie entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
