using Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
