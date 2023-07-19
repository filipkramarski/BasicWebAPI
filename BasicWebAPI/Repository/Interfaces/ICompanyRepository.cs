using BasicWebAPI.Models;

namespace BasicWebAPI.Repository.Interfaces
{
    public interface ICompanyRepository
    {
        Task CreateAsync(Company company);
        Task<List<Company>> GetAllAsync();
        void Update(Company company);
        void Delete(Company company);
        Task<Company> GetCompanyByIdAsync(int companyId);
    }
}
