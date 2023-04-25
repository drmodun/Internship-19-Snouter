using Data.Entities;
using Data.Entities.Models;
using Domain.Contracts.Requests.Country;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class CountryRepo
    {
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);

        public CountryRepo(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public async Task<Country> GetCountry(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                return await Task.FromResult(await _shopContext.Countries.FirstOrDefaultAsync(c => c.Id == id, cancellationToken));
            } catch (DbUpdateException)
            {
                return null;
            }
        }
        public async Task<List<Country>> GetAllCountries()
        {
            return await Task.FromResult(await _shopContext.Countries.ToListAsync());
        }
        public async Task<bool> CreateCountry(Country country, CancellationToken cancellationToken = default) { 
            await _shopContext.Countries.AddAsync(country);
            return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
        }
        public async Task<bool> DeleteCountry(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                var countryToRemove = await GetCountry(id);
                if (countryToRemove == null) return false;
                _shopContext.Countries.Remove(countryToRemove);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            } catch (DbUpdateException) { 
                return false;
               
            }
        }
        public async Task<bool> UpdateCountry(Country country, CancellationToken cancellationToken = default)
        {
            try
            {
                var countryToDelete = await GetCountry(country.Id);
                if (countryToDelete == null) return false;
                _shopContext.Countries.Remove(countryToDelete);
                await _shopContext.AddAsync(country);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }



    }
}
