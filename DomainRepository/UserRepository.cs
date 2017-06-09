using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.DomainRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly FinalProjectContext _context;

        public UserRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<User> Delete(User entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.Where(u => !u.IsDeleted).ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> Insert(User entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> Update(User entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
