using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using BasicWebAPI.Services.Interfaces;

namespace BasicWebAPI.Services.Implementation
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task CreateCompanyAsync(Company company)
        {
            await _companyRepository.CreateAsync(company);
        }

        public async Task<List<Company>> GetAllCompaniesAsync()
        {
            return await _companyRepository.GetAllAsync();
        }

        public void UpdateCompany(Company company)
        {
            _companyRepository.Update(company);
        }

        public void DeleteCompany(Company company)
        {
            _companyRepository.Delete(company);
        }

        public async Task<Company> GetCompanyByIdAsync(int companyId)
        {
            return await _companyRepository.GetCompanyByIdAsync(companyId);
        }
    }
}
