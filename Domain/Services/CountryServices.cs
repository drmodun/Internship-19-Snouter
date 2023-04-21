using Domain.Contracts.Requests.Country;
using Domain.Contracts.Response.Country;
using Domain.Mapper;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CountryServices
    {
        private CountryRepo _countryRepo { get; set; }
        private EntityMaker _entityMaker { get; set; }

        public async Task<GetCountryResponse> GetCountryService(GetCountryRequest request)
        {
            var country = await _countryRepo.GetCountry(request.Id);
            if (country == null)
            {
                return new GetCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Country = null
                };
            }
            return new GetCountryResponse
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true,
                Country = LocationMapper.CountryToDTO(country)
            };
        }
        public async Task<GetAllCountriesResponse> GetAllCountriesService()
        {
            var countries = await _countryRepo.GetAllCountries();
            return new GetAllCountriesResponse
            {
                Countries = countries.Select(LocationMapper.CountryToDTO).ToList()
            };
        }
        public async Task<CreateCountryResponse> CreateCountryService(CreateCountryRequest request)
        {
            var newCountry = _entityMaker.RequestToNewCountry(request);
            if (newCountry == null)
            {
                return new CreateCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Country = null
                };
            }
            var addition = await _countryRepo.CreateCountry(newCountry);
            if (!addition)
            {
                return new CreateCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Country = null
                };
            }
            return new CreateCountryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Country = LocationMapper.CountryToDTO(newCountry)
            };
        }
        public async Task<UpdateCountryResponse> UpdateCountryService(UpdateCountryRequest request)
        {
            var country = await _countryRepo.GetCountry(request.Id);
            if (country == null)
            {
                return new UpdateCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Country = null
                };
            }
            var updatedCountry = _entityMaker.RequestToUpdatedCountry(request);
            var update = await _countryRepo.UpdateCountry(updatedCountry);
            if (!update)
            {
                return new UpdateCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Country = null
                };
            }
            return new UpdateCountryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Country = LocationMapper.CountryToDTO(updatedCountry)
            };
        }
        public async Task<DeleteCountryResponse> DeleteCountryService(DeleteCountryRequest request)
        {
            var country = await _countryRepo.GetCountry(request.Id);
            if (country == null)
            {
                return new DeleteCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }
            var delete = await _countryRepo.DeleteCountry(country.Id);
            if (!delete)
            {
                return new DeleteCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
            }
            return new DeleteCountryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
    }
}
