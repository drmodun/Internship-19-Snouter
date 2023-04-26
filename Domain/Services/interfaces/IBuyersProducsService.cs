using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Response.BuyersProducts;

namespace Domain.Services
{
    public interface IBuyersProductsService
    {
        Task<GetBuyersProductsResponse> GetConnectionService(GetBuyersProudctsRequest request, CancellationToken cancellationToken = default);
        Task<GetAllBuyersProductsResponse> GetAllBuyersProductsService();
        Task<CreateBuyersProductsResponse> CreateConnectionService(CreateBuyersProductsRequest request, CancellationToken cancellationToken = default);
        Task<UpdateBuyersProductsResponse> UpdateConnectionService(UpdateBuyersProductsRequest request, CancellationToken cancellationToken = default);
        Task<DeleteBuyersProductsResponse> DeleteConnectionService(DeleteBuyersProductsRequest request, CancellationToken cancellationToken = default);

    }
}
