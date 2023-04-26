using Data.Entities.Models;

namespace Domain.Repositories.Interfaces
{
    public interface ICountryRepo
    {
        public Task<Country> GetCountry(Guid id, CancellationToken cancellationToken = default);
        public Task<List<Country>> GetAllCountries();
        public Task<bool> CreateCountry(Country Country, CancellationToken cancellationToken = default);
        public Task<bool> UpdateCountry(Country Country, CancellationToken cancellationToken = default);
        public Task<bool> DeleteCountry(Guid id, CancellationToken cancellationToken = default);


    }
}
