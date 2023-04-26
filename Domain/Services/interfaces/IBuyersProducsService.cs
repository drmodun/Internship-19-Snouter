using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Contracts.Requests.BuyersProducts;

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
