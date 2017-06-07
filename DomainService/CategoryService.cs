using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public class CategoryService : ICategoryService
    {
        private readonly FinalProjectContext _context;

        public CategoryService(FinalProjectContext context)
        {
            _context = context;
        }

        public async void Delete(Category entity)
        {
            var user = await _context.Categories.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Categories.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categories.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async void Insert(Category entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(Category entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
