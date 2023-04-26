using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Contracts.Response.Product;
using Domain.Contracts.Response.User;
using Domain.Mapper.Implementaions;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Implmentations
{
    public class BuyersProductsService : IBuyersProductsService
    {
        private EntityMaker _entityMaker { get; set; }
        private IBuyersProductsRepo _buyersProductsRepo { get; set; }

        private IProductsMapper _productsMapper { get; set; }
        private BuyersProductsValidator _buyersProductsValidator { get; set; }

        public BuyersProductsService(IBuyersProductsRepo buyersProductsRepo, EntityMaker entityMaker, IProductsMapper productsMapper, BuyersProductsValidator validationRules)
        {
            _buyersProductsRepo = buyersProductsRepo;
            _entityMaker = entityMaker;
            _productsMapper = productsMapper;
            _buyersProductsValidator = validationRules;
        }

        public async Task<GetBuyersProductsResponse> GetConnectionService(GetBuyersProudctsRequest request, CancellationToken cancellationToken = default)
        {
            var buyersProducts = await _buyersProductsRepo.GetConnection(request.ProductId, request.UserId, cancellationToken);
            if (buyersProducts == null)
            {
                return new GetBuyersProductsResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.NotFound,
                    BuyersProducts = null
                };
            }
            return new GetBuyersProductsResponse
            {
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
                BuyersProducts = _productsMapper.BuyersProductsToDto(buyersProducts)
            };
        }
        public async Task<GetAllBuyersProductsResponse> GetAllBuyersProductsService()
        {
            var buyersProducts = await _buyersProductsRepo.GetAllConnections();
            return new GetAllBuyersProductsResponse
            {
                BuyersProducts = buyersProducts.Select(_productsMapper.BuyersProductsToDto).ToList()
            };
        }
        public async Task<CreateBuyersProductsResponse> CreateConnectionService(CreateBuyersProductsRequest request, CancellationToken cancellationToken = default)
        {
            var newConnection = _entityMaker.RequestToNewBuyersProducts(request);
            await _buyersProductsValidator.ValidateAndThrowAsync(newConnection);
            var addition = await _buyersProductsRepo.CreateConnection(newConnection, cancellationToken);
            if (!addition)
            {
                return new CreateBuyersProductsResponse
                {
                    Success = false,
                    BuyersProducts = null,
                    Status = System.Net.HttpStatusCode.BadRequest
                };
            }
            return new CreateBuyersProductsResponse
            {
                Success = true,
                BuyersProducts = _productsMapper.BuyersProductsToDto(newConnection),
                Status = System.Net.HttpStatusCode.BadRequest
            };
        }
        public async Task<DeleteBuyersProductsResponse> DeleteConnectionService(DeleteBuyersProductsRequest request, CancellationToken cancellationToken = default)
        {
            var removal = await _buyersProductsRepo.DeleteConnection(request.ProductId, request.UserId, cancellationToken);
            if (!removal)
            {
                return new DeleteBuyersProductsResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.NotFound,
                };
            }
            return new DeleteBuyersProductsResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
            };
        }
        public async Task<UpdateBuyersProductsResponse> UpdateConnectionService(UpdateBuyersProductsRequest request, CancellationToken cancellationToken = default)
        {
            var updatedConnection = _entityMaker.RequestToUpdatedBuyersProducts(request);
            await _buyersProductsValidator.ValidateAndThrowAsync(updatedConnection);
            var update = await _buyersProductsRepo.UpdateConnection(updatedConnection, cancellationToken);
            if (!update)
            {
                return new UpdateBuyersProductsResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.NotFound,
                    BuyersProducts = null
                };
            }
            return new UpdateBuyersProductsResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                BuyersProducts = _productsMapper.BuyersProductsToDto(updatedConnection)
            };
        }
    }
}
