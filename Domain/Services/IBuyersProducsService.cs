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
        Task<GetBuyersProductsResponse> GetConnectionService(GetBuyersProudctsRequest request);
        Task<GetAllBuyersProductsResponse> GetAllBuyersProductsService();
        Task<CreateBuyersProductsResponse> CreateConnectionService(CreateBuyersProductsRequest request);
        Task<UpdateBuyersProductsResponse> UpdateConnectionService(UpdateBuyersProductsRequest request);
        Task<DeleteBuyersProductsResponse> DeleteConnectionService(DeleteBuyersProductsRequest request);

    }
}
