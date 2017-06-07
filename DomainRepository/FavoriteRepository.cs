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

        public async void Delete(Favorite entity)
        {
            var user = await _context.Favorites.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Favorites.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Favorite> Get(int id)
        {
            return await _context.Favorites.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Favorite>> GetAll()
        {
            return await _context.Favorites.ToListAsync();
        }

        public async void Insert(Favorite entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(Favorite entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
