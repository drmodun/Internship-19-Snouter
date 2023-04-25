using Domain.Contracts.Requests.Location;
using Domain.Contracts.Response.Location;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class LocationControllers : ControllerBase
    {
        private readonly LocationServices _locationService;
        public LocationControllers(LocationServices locationService)
        {
            _locationService = locationService;
        }
        [HttpGet(Routes.Location.Get)]
        public async Task<ActionResult<GetLocationResponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetLocationRequest { Id = id };
            var response = await _locationService.GetLocationService(request, cancellationToken);
            if (response.Location == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.Location.Create)]
        public async Task<ActionResult<CreateLocationResponse>> Post([FromBody] CreateLocationRequest request, CancellationToken cancellationToken)
        {
            var response = await _locationService.CreateLocationService(request, cancellationToken);
            if (response.Location == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.Location.Update)]
        public async Task<ActionResult<UpdateLocationResponse>> Put([FromRoute] Guid id,[FromBody] CreateLocationRequest request, CancellationToken cancellationToken)
        {
            var updateRequest = new UpdatedLocationRequest { Id = id, Name = request.Name, Latitude = request.Latitude, Longitude = request.Longitude, CountryId = request.CountryId};
            var response = await _locationService.UpdateLocationService(updateRequest, cancellationToken);
            if (response.Location == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.Location.Delete)]
        public async Task<ActionResult<DeleteLocationResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteLocationRequest { Id = id };
            var response = await _locationService.DeleteLocationService(request, cancellationToken);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpGet(Routes.Location.GetAll)]
        public async Task<ActionResult<GetAllLocationsResponse>> GetAll()
        {
            var response = await _locationService.GetAllLocationsService();
            if (response.Locations == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
