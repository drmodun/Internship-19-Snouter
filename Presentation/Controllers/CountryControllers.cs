using Domain.Constants;
using Domain.Contracts.Requests.Country;
using Domain.Contracts.Response.Country;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class CountryControllers : ControllerBase
    {
        private readonly ICountryServices _countryService;
        public CountryControllers(ICountryServices countryService)
        {
            _countryService = countryService;
        }
        [AllowAnonymous]
        [HttpGet(Routes.Country.Get)]
        public async Task<ActionResult<GetCountryResponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetCountryRequest { Id = id };
            var response = await _countryService.GetCountryService(request, cancellationToken);
            if (response.Country == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPost(Routes.Country.Create)]
        public async Task<ActionResult<CreateCountryResponse>> Post([FromBody] CreateCountryRequest request, CancellationToken cancellationToken)
        {
            var response = await _countryService.CreateCountryService(request, cancellationToken);
            if (response.Country == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPut(Routes.Country.Update)]
        public async Task<ActionResult<UpdateCountryResponse>> Put([FromRoute] Guid id, [FromBody] CreateCountryRequest requestCreate, CancellationToken cancellationToken)
        {
            var request = new UpdateCountryRequest { Id = id, Name = requestCreate.Name, Image = requestCreate.Image };
            var response = await _countryService.UpdateCountryService(request, cancellationToken);
            if (response.Country == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpDelete(Routes.Country.Delete)]
        public async Task<ActionResult<DeleteCountryResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteCountryRequest { Id = id };
            var response = await _countryService.DeleteCountryService(request, cancellationToken);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [AllowAnonymous]
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
