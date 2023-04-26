﻿using Domain.Contracts.Requests.Location;
using Domain.Contracts.Response.Location;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;

namespace Domain.Services.Implmentations
{
    public class LocationServices : ILocationServices
    {
        private ILocationRepo _locationRepo { get; set; }
        private EntityMaker _entityMaker { get; set; }
        private ILocationMapper _locationMapper { get; set; }

        private LocationsValidator _locationValidator { get; set; }

        public LocationServices(ILocationRepo locationRepo, EntityMaker entityMaker, ILocationMapper locationMapper, LocationsValidator validationRules)
        {
            _locationRepo = locationRepo;
            _entityMaker = entityMaker;
            _locationMapper = locationMapper;
            _locationValidator = validationRules;
        }
        public async Task<GetLocationResponse> GetLocationService(GetLocationRequest request, CancellationToken cancellationToken = default)
        {
            var location = await _locationRepo.GetLocationById(request.Id, cancellationToken);
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
        public async Task<CreateLocationResponse> CreateLocationService(CreateLocationRequest request, CancellationToken cancellationToken = default)
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
            var addition = await _locationRepo.CreateLocation(newLocation, cancellationToken);
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
        public async Task<UpdateLocationResponse> UpdateLocationService(UpdatedLocationRequest request, CancellationToken cancellationToken = default)
        {
            var location = await _locationRepo.GetLocationById(request.Id, cancellationToken);
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
            var update = await _locationRepo.UpdateLocation(updatedLocation, cancellationToken);
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
        public async Task<DeleteLocationResponse> DeleteLocationService(DeleteLocationRequest request, CancellationToken cancellationToken = default)
        {
            var location = await _locationRepo.GetLocationById(request.Id, cancellationToken);
            if (location == null)
            {
                return new DeleteLocationResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                };
            }
            var delete = await _locationRepo.DeleteLocation(location.Id, cancellationToken);
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