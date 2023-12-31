﻿using BasicWebAPI.Data;
using BasicWebAPI.Models;
using BasicWebAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace BasicWebAPI.Repository.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CountryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Country country)
        {
            try
            {
                await _dbContext.Set<Country>().AddAsync(country);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while creating the country.", ex);
            }
        }

        public async Task<List<Country>> GetAllAsync()
        {
            try
            {
                return await _dbContext.Set<Country>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while fetching all countries.", ex);
            }
        }

        public void Update(Country country)
        {
            try
            {
                _dbContext.Entry(country).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while updating the country.", ex);
            }
        }

        public void Delete(Country country)
        {
            try
            {
                _dbContext.Set<Country>().Remove(country);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while deleting the country.", ex);
            }
        }

        public async Task<Country> GetCountryByIdAsync(int countryId)
        {
            try
            {
                return await _dbContext.Country.FindAsync(countryId);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while fetching the country by ID.", ex);
            }
        }
    }
}
