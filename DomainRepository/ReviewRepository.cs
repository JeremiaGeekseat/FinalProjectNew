using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly FinalProjectContext _context;

        public ReviewRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<Review> Delete(Review entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Review> Get(int id)
        {
            return await _context.Reviews.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Review>> GetAll()
        {
            return await _context.Reviews.Where(r => !r.IsDeleted).ToListAsync();
        }

        public async Task<Review> Insert(Review entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Review> Update(Review entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
