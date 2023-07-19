using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using BasicWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Implementation
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task CreateCountryAsync(Country country)
        {
            await _countryRepository.CreateAsync(country);
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            return await _countryRepository.GetAllAsync();
        }

        public void UpdateCountry(Country country)
        {
            _countryRepository.Update(country);
        }

        public void DeleteCountry(Country country)
        {
            _countryRepository.Delete(country);
        }

        public async Task<Country> GetCountryByIdAsync(int countryId)
        {
            return await _countryRepository.GetCountryByIdAsync(countryId);
        }
    }
}
