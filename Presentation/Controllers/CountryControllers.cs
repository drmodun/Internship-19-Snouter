using Domain.Contracts.Requests.Country;
using Domain.Contracts.Response.Country;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class CountryControllers : ControllerBase
    {
        private readonly CountryServices _countryService;
        public CountryControllers(CountryServices countryService)
        {
            _countryService = countryService;
        }
        [HttpGet(Routes.Country.Get)]
        public async Task<ActionResult<GetCountryResponse>> Get([FromRoute] Guid id)
        {
            var request = new GetCountryRequest { Id = id };
            var response = await _countryService.GetCountryService(request);
            if (response.Country == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.Country.Create)]
        public async Task<ActionResult<CreateCountryResponse>> Post([FromBody] CreateCountryRequest request)
        {
            var response = await _countryService.CreateCountryService(request);
            if (response.Country == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.Country.Update)]
        public async Task<ActionResult<UpdateCountryResponse>> Put([FromRoute] Guid id, [FromBody] CreateCountryRequest requestCreate)
        {
            var request = new UpdateCountryRequest { Id = id, Name = requestCreate.Name, Image = requestCreate.Image};
            var response = await _countryService.UpdateCountryService(request);
            if (response.Country == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.Country.Delete)]
        public async Task<ActionResult<DeleteCountryResponse>> Delete([FromRoute] Guid id)
        {
            var request = new DeleteCountryRequest { Id = id };
            var response = await _countryService.DeleteCountryService(request);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpGet(Routes.Country.GetAll)]
        public async Task<ActionResult<GetAllCountriesResponse>> GetAll()
        {
            var response = await _countryService.GetAllCountriesService();
            if (response.Countries == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
