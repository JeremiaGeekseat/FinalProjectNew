using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly FinalProjectContext _context;

        public ContactRepository(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<Contact> Delete(Contact entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Contact> Get(int id)
        {
            return await _context.Contacts.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<Contact> Insert(Contact entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Contact> Update(Contact entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
