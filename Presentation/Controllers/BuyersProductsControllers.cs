using Domain.Constants;
using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Services;
using Domain.Services.Implmentations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class BuyersProductsControllers : ControllerBase
    {
        private readonly IBuyersProductsService _buyersProductsService;
        public BuyersProductsControllers(IBuyersProductsService buyersProductsService)
        {
            _buyersProductsService = buyersProductsService;
        }
        [AllowAnonymous]
        [HttpGet(Routes.BuyersProducts.Get)]
        public async Task<ActionResult<GetBuyersProductsResponse>> GetConnection([FromRoute] Guid ProductId, [FromRoute] Guid BuyerId, CancellationToken cancellationToken)
        {
            var request = new GetBuyersProudctsRequest
            {
                ProductId = ProductId,
                UserId = BuyerId
            };
            var connection = await _buyersProductsService.GetConnectionService(request, cancellationToken);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpPost(Routes.BuyersProducts.Create)]
        public async Task<ActionResult<CreateBuyersProductsResponse>> CreateConnection([FromRoute] Guid productId, [FromRoute] Guid buyerId, [FromBody] int quantity, CancellationToken cancellationToken)
        {
            var request = new CreateBuyersProductsRequest
            {
                ProductId = productId,
                UserId = buyerId,
                Quantity = quantity,
            };
            var connection = await _buyersProductsService.CreateConnectionService(request, cancellationToken);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpDelete(Routes.BuyersProducts.Delete)]
        public async Task<ActionResult<DeleteBuyersProductsResponse>> DeleteConnection([FromRoute] Guid ProductId, [FromRoute] Guid BuyerId, CancellationToken cancellationToken)
        {
            var request = new DeleteBuyersProductsRequest
            {
                ProductId = ProductId,
                UserId = BuyerId
            };
            var connection = await _buyersProductsService.DeleteConnectionService(request, cancellationToken);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpPut(Routes.BuyersProducts.Update)]
        public async Task<ActionResult<UpdateBuyersProductsResponse>> UpdateConnection([FromRoute] Guid productId, [FromRoute] Guid buyerId, [FromBody] int quantity, CancellationToken cancellationToken)
        {
            var request = new UpdateBuyersProductsRequest
            {
                ProductId = productId,
                UserId = buyerId,
                Quantity = quantity
            };
            var connection = await _buyersProductsService.UpdateConnectionService(request, cancellationToken);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [AllowAnonymous]
        [HttpGet(Routes.BuyersProducts.GetAll)]
        public async Task<ActionResult<GetAllBuyersProductsResponse>> GetAllConnections()
        {
            var connections = await _buyersProductsService.GetAllBuyersProductsService();
            if (connections == null)
                return BadRequest();
            return Ok(connections);
        }
    }
}
