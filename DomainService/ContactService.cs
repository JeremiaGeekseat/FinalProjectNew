using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public class ContactService : IContactService
    {
        private readonly FinalProjectContext _context;

        public ContactService(FinalProjectContext context)
        {
            _context = context;
        }

        public async void Delete(Contact entity)
        {
            var user = await _context.Contacts.SingleOrDefaultAsync(u => u.Id == entity.Id);
            _context.Contacts.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Contact> Get(int id)
        {
            return await _context.Contacts.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts.ToListAsync();
        }
        
        public async void Insert(Contact entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(Contact entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
