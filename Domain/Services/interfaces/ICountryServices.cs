using Domain.Contracts.Requests.Country;
using Domain.Contracts.Response.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces
{
    public interface ICountryServices // use CountryServices class to write this interface
    {
        public Task<GetAllCountriesResponse> GetAllCountriesService(CancellationToken cancellationToken);
        public Task<GetCountryResponse> GetCountryService(GetCountryRequest request, CancellationToken cancellationToken = default);
        public Task<CreateCountryResponse> CreateCountryService(CreateCountryRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteCountryResponse> DeleteCountryService(DeleteCountryRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateCountryResponse> UpdateCountryService(UpdateCountryRequest request, CancellationToken cancellationToken = default);

    }
}
