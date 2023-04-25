using Domain.Contracts.Requests.Location;
using Domain.Contracts.Response.Location;
using Domain.Mapper;
using Domain.Repositories;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class LocationServices
    {
        private LocationRepo _locationRepo { get; set; }
        private EntityMaker _entityMaker { get; set; }
        private LocationMapper _locationMapper { get; set; }

        private LocationsValidator _locationValidator { get; set; }

        public LocationServices(LocationRepo locationRepo, EntityMaker entityMaker, LocationMapper locationMapper, LocationsValidator validationRules)
        {
            _locationRepo = locationRepo;
            _entityMaker = entityMaker;
            _locationMapper = locationMapper;
            _locationValidator = validationRules;
        }
        public async Task<GetLocationResponse> GetLocationService(GetLocationRequest request)
        {
            var location = await _locationRepo.GetLocationById(request.Id);
            if (location == null)
            {
                return new GetLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Location = null
                };
            }
            return new GetLocationResponse
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true,
                Location = _locationMapper.LocationToDTO(location)
            };
        }
        public async Task<GetAllLocationsResponse> GetAllLocationsService()
        {
            var locations = await _locationRepo.GetAllLocations();
            return new GetAllLocationsResponse
            {
                Locations = locations.Select(_locationMapper.LocationToDTO).ToList()
            };
        }
        public async Task<CreateLocationResponse> CreateLocationService(CreateLocationRequest request)
        {
            var newLocation = _entityMaker.RequestToNewLocation(request);
            await _locationValidator.ValidateAndThrowAsync(newLocation);
            if (newLocation == null)
            {
                return new CreateLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Location = null
                };
            }
            var addition = await _locationRepo.CreateLocation(newLocation);
            if (!addition)
            {
                return new CreateLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Location = null
                };
            }
            return new CreateLocationResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Location = _locationMapper.LocationToDTO(newLocation)
            };
        }
        public async Task<UpdateLocationResponse> UpdateLocationService(UpdatedLocationRequest request)
        {
            var location = await _locationRepo.GetLocationById(request.Id);
            if (location == null)
            {
                return new UpdateLocationResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.NotFound,
                    Location = null
                };
            }
            var updatedLocation = _entityMaker.RequestToUpdatedLocation(request);
            if (updatedLocation == null)
            {
                return new UpdateLocationResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Location = null
                };
            }
            var update = await _locationRepo.UpdateLocation(updatedLocation);
            await _locationValidator.ValidateAndThrowAsync(updatedLocation);
            if (!update)
            {
                return new UpdateLocationResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Location = null
                };
            }
            return new UpdateLocationResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                Location = _locationMapper.LocationToDTO(updatedLocation)
            };
        }
        public async Task<DeleteLocationResponse> DeleteLocationService(DeleteLocationRequest request)
        {
            var location = await _locationRepo.GetLocationById(request.Id);
            if (location == null)
            {
                return new DeleteLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                };
            }
            var delete = await _locationRepo.DeleteLocation(location.Id);
            if (!delete)
            {
                return new DeleteLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                };
            }
            return new DeleteLocationResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
    }
}
