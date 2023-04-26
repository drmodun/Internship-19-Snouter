using Domain.Contracts.Requests.Country;
using Domain.Contracts.Response.Country;
using Domain.Mapper.Implementaions;
using Domain.Repositories;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CountryServices : ICountryServices
    {
        private CountryRepo _countryRepo { get; set; }
        private EntityMaker _entityMaker { get; set; }

        private LocationMapper _locationMapper { get; set; }

        private CountriesValidator _countryValidator { get; set; }



        public CountryServices(CountryRepo countryRepo, EntityMaker entityMaker, LocationMapper locationMapper, CountriesValidator validationRules)
        {
            _countryRepo = countryRepo;
            _entityMaker = entityMaker;
            _locationMapper = locationMapper;
            _countryValidator = validationRules;
        }


        public async Task<GetCountryResponse> GetCountryService(GetCountryRequest request, CancellationToken cancellationToken = default)
        {
            var country = await _countryRepo.GetCountry(request.Id, cancellationToken);
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
                Country = _locationMapper.CountryToDTO(country)
            };
        }
        public async Task<GetAllCountriesResponse> GetAllCountriesService()
        {
            var countries = await _countryRepo.GetAllCountries();
            return new GetAllCountriesResponse
            {
                Countries = countries.Select(_locationMapper.CountryToDTO).ToList()
            };
        }
        public async Task<CreateCountryResponse> CreateCountryService(CreateCountryRequest request, CancellationToken cancellationToken = default)
        {
            var newCountry = _entityMaker.RequestToNewCountry(request);
            await _countryValidator.ValidateAndThrowAsync(newCountry);
            if (newCountry == null)
            {
                return new CreateCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Country = null
                };
            }
            var addition = await _countryRepo.CreateCountry(newCountry, cancellationToken);
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
                Country = _locationMapper.CountryToDTO(newCountry)
            };
        }
        public async Task<UpdateCountryResponse> UpdateCountryService(UpdateCountryRequest request, CancellationToken cancellationToken = default)
        {
            var country = await _countryRepo.GetCountry(request.Id, cancellationToken);
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
            await _countryValidator.ValidateAndThrowAsync(updatedCountry);
            var update = await _countryRepo.UpdateCountry(updatedCountry, cancellationToken);
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
                Country = _locationMapper.CountryToDTO(updatedCountry)
            };
        }
        public async Task<DeleteCountryResponse> DeleteCountryService(DeleteCountryRequest request, CancellationToken cancellationToken = default)
        {
            var country = await _countryRepo.GetCountry(request.Id, cancellationToken);
            if (country == null)
            {
                return new DeleteCountryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }
            var delete = await _countryRepo.DeleteCountry(country.Id, cancellationToken);
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
