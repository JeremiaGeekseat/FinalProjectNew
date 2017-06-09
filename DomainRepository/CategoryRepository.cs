using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FinalProjectContext _context;

        public CategoryRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<Category> Delete(Category entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categories.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<Category> Insert(Category entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> Update(Category entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
