using BasicWebAPI.Data;
using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BasicWebAPI.Repository.Implementation
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Company company)
        {
            await _dbContext.Set<Company>().AddAsync(company);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Company>> GetAllAsync()
        {
            return await _dbContext.Set<Company>().ToListAsync();
        }

        public void Update(Company company)
        {
            _dbContext.Entry(company).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Company company)
        {
            _dbContext.Set<Company>().Remove(company);
            _dbContext.SaveChanges();
        }

        public async Task<Company> GetCompanyByIdAsync(int companyId)
        {
            return await _dbContext.Company.FindAsync(companyId);            
        }
    }
}
