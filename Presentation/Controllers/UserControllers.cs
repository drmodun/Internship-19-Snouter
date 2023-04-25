using Domain.Contracts.Requests.Product;
using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.Product;
using Domain.Contracts.Response.User;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class UserControllers : ControllerBase
    {
        private readonly UserServices _userService;
         
        public UserControllers(UserServices userService)
        {
            _userService = userService;
        }
        [HttpGet(Routes.User.Get)]
        public async Task<ActionResult<GetUserResponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetUserRequest { Id = id };
            var response = await _userService.GetUserService(request, cancellationToken);
            if (response.User == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.User.Create)]
        public async Task<ActionResult<CreateUserResponse>> Post([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.CreateUserService(request, cancellationToken);
            if (response.Profile == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.User.Update)]
        public async Task<ActionResult<UpdateUserResponse>> Put([FromRoute] Guid id, [FromBody] CreateUserRequest request, CancellationToken cancellationToken)
        {
            var updateRequest = new UpdateUserRequest
            {
                Id = id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                LocationId = request.LocationId,
                isAdmin = request.IsAdmin

            };
            var response = await _userService.UpdateUserService(updateRequest, cancellationToken);
            if (response.User == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.User.Delete)]
        public async Task<ActionResult<DeleteUserResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteUserRequest { Id = id };
            var response = await _userService.DeleteUserService(request, cancellationToken);
            if (!response.Success)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpGet(Routes.User.GetAll)]
        public async Task<ActionResult<GetAllUsersResponse>> GetAll()
        {
            var response = await _userService.GetAllUsersService();
            if (response.Users == null)
                return BadRequest();
            return Ok(response);
        }
    }
}
