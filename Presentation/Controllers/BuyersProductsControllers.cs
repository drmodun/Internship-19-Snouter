using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class BuyersProductsControllers : ControllerBase
    {
        private readonly BuyersProductsService _buyersProductsService;
        public BuyersProductsControllers(BuyersProductsService buyersProductsService)
        {
            _buyersProductsService = buyersProductsService;
        }
        [HttpGet(Routes.BuyersProducts.Get)]
        public async Task<ActionResult<GetBuyersProductsResponse>> GetConnection([FromRoute] Guid ProductId, [FromRoute] Guid BuyerId)
        {
            var request = new GetBuyersProudctsRequest
            {
                ProductId = ProductId,
                UserId = BuyerId
            };
            var connection = _buyersProductsService.GetConnectionService(request);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [HttpPost(Routes.BuyersProducts.Create)]
        public async Task<ActionResult<CreateBuyersProductsResponse>> CreateConnection([FromRoute] Guid productId, [FromRoute] Guid buyerId, [FromBody] int quantity)
        {
            var request = new CreateBuyersProductsRequest
            {
                ProductId = productId,
                UserId = buyerId,
                Quantity = quantity,
            };
            var connection = _buyersProductsService.CreateConnectionService(request);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [HttpDelete(Routes.BuyersProducts.Delete)]
        public async Task<ActionResult<DeleteBuyersProductsResponse>> DeleteConnection([FromRoute] Guid ProductId, [FromRoute] Guid BuyerId)
        {
            var request = new DeleteBuyersProductsRequest
            {
                ProductId = ProductId,
                UserId = BuyerId
            };
            var connection = _buyersProductsService.DeleteConnectionService(request);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
        [HttpPut(Routes.BuyersProducts.Update)]
        public async Task<ActionResult<UpdateBuyersProductsResponse>> UpdateConnection([FromRoute] Guid productId, [FromRoute] Guid buyerId, [FromBody] int quantity)
        {
            var request = new UpdateBuyersProductsRequest
            {
                ProductId = productId,
                UserId = buyerId,
                Quantity = quantity
            };
            var connection = _buyersProductsService.UpdateConnectionService(request);
            if (connection == null)
                return BadRequest();
            return Ok(connection);
        }
    }
}
