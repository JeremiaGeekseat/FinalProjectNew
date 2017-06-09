using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly FinalProjectContext _context;

        public FavoriteRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<Favorite> Delete(Favorite entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Favorite> Get(int id)
        {
            return await _context.Favorites.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Favorite>> GetAll()
        {
            return await _context.Favorites.Where(f => !f.IsDeleted).ToListAsync();
        }

        public async Task<Favorite> Insert(Favorite entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Favorite> Update(Favorite entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
