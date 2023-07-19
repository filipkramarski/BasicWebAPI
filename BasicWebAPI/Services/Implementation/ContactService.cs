using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using BasicWebAPI.Services.Interfaces;

namespace BasicWebAPI.Services.Implementation
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task CreateContactAsync(Contact contact)
        {
            await _contactRepository.AddAsync(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _contactRepository.Delete(contact);
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await _contactRepository.GetAllAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int contactId)
        {
            return await _contactRepository.GetContactByIdAsync(contactId);
        }

        public void UpdateContact(Contact contact)
        {
            _contactRepository.Update(contact);
        }

        public async Task<List<Contact>> FilterContactsAsync(int? countryId, int? companyId)
        {
            return await _contactRepository.FilterContactsAsync(countryId, companyId);
        }
    }
}
