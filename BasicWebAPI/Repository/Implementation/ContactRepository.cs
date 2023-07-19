using BasicWebAPI.Data;
using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BasicWebAPI.Repository.Implementation
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Contact contact)
        {
            await _dbContext.Set<Contact>().AddAsync(contact);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(Contact contact)
        {
            _dbContext.Set<Contact>().Remove(contact);
            _dbContext.SaveChanges();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _dbContext.Set<Contact>().Include(c => c.Company).Include(c => c.Country).ToListAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int contactId)
        {
            return await _dbContext.Contact.FindAsync(contactId);
        }

        public void Update(Contact contact)
        {
            _dbContext.Contact.Update(contact);
            _dbContext.SaveChanges();
        }

        public async Task<List<Contact>> FilterContactsAsync(int? countryId, int? companyId)
        {
            IQueryable<Contact> query = _dbContext.Set<Contact>()
                .Include(c => c.Company)
                .Include(c => c.Country);

            if (countryId.HasValue)
            {
                query = query.Where(contact => contact.CountryId == countryId.Value);
            }

            if (companyId.HasValue)
            {
                query = query.Where(contact => contact.CompanyId == companyId.Value);
            }

            return await query.ToListAsync();
        }
    }
}
