using Data.Entities.Models;

namespace Domain.Repositories.Interfaces
{
    public interface ILocationRepo
    {
        public Task<Location> GetLocationById(Guid id, CancellationToken cancellationToken = default);
        public Task<List<Location>> GetAllLocations();
        public Task<bool> CreateLocation(Location Location, CancellationToken cancellationToken = default);
        public Task<bool> UpdateLocation(Location Location, CancellationToken cancellationToken = default);
        public Task<bool> DeleteLocation(Guid id, CancellationToken cancellationToken = default);


    }
}
