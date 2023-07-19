using BasicWebAPI.Models;

namespace BasicWebAPI.Repository.Interfaces
{
    public interface IContactRepository
    {
        Task AddAsync(Contact contact);
        void Delete(Contact contact);
        Task<List<Contact>> GetAllAsync();
        Task<Contact> GetContactByIdAsync(int contactId);
        void Update(Contact contact);
        Task<List<Contact>> FilterContactsAsync(int? countryId, int? companyId);

    }
}
