using Domain.Contracts.Requests.Location;
using Domain.Contracts.Response.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces
{
    public interface ILocationServices 
    {
        public Task<GetAllLocationsResponse> GetAllLocationsService();
        public Task<GetLocationResponse> GetLocationService(GetLocationRequest request, CancellationToken cancellationToken = default);
        public Task<CreateLocationResponse> CreateLocationService(CreateLocationRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteLocationResponse> DeleteLocationService(DeleteLocationRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateLocationResponse> UpdateLocationService(UpdatedLocationRequest request, CancellationToken cancellationToken = default);
    }
}
