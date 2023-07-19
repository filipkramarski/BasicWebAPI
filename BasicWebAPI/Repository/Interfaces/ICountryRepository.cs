using BasicWebAPI.Models;

namespace BasicWebAPI.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task CreateAsync(Country country);
        Task<List<Country>> GetAllAsync();
        void Update(Country country);
        void Delete(Country country);
        Task<Country> GetCountryByIdAsync(int countryId);
    }
}
