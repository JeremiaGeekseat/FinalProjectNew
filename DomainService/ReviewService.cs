using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public class ReviewService : IReviewService
    {
        private readonly FinalProjectContext _context;

        public ReviewService(FinalProjectContext context)
        {
            _context = context;
        }

        public async void Delete(Review entity)
        {
            var user = await _context.Reviews.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Reviews.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Review> Get(int id)
        {
            return await _context.Reviews.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Review>> GetAll()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async void Insert(Review entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(Review entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
