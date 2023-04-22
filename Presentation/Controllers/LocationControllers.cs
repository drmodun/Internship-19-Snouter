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
        public async Task<ActionResult<GetLocationResponse>> Get([FromRoute] Guid id)
        {
            var request = new GetLocationRequest { Id = id };
            var response = await _locationService.GetLocationService(request);
            if (response.Location == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.Location.Create)]
        public async Task<ActionResult<CreateLocationResponse>> Post([FromBody] CreateLocationRequest request)
        {
            var response = await _locationService.CreateLocationService(request);
            if (response.Location == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.Location.Update)]
        public async Task<ActionResult<UpdateLocationResponse>> Put([FromBody] UpdatedLocationRequest request)
        {
            var response = await _locationService.UpdateLocationService(request);
            if (response.Location == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.Location.Delete)]
        public async Task<ActionResult<DeleteLocationResponse>> Delete([FromRoute] Guid id)
        {
            var request = new DeleteLocationRequest { Id = id };
            var response = await _locationService.DeleteLocationService(request);
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
