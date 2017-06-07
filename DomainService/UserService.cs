using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public class UserService : IUserService
    {
        private readonly FinalProjectContext _context;

        public UserService(FinalProjectContext context)
        {
            _context = context;
        }

        public async void Delete(User entity)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async void Insert(User entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(User entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
