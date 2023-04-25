using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Contracts.Response.Product;
using Domain.Contracts.Response.User;
using Domain.Mapper;
using Domain.Repositories;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class BuyersProductsService : IBuyersProductsService
    {
        private  EntityMaker _entityMaker { get; set; }
        private BuyersProductsRepo _buyersProductsRepo { get; set; }

        private ProductsMapper _productsMapper { get; set; }
        private BuyersProductsValidator _buyersProductsValidator { get; set; }

        public BuyersProductsService(BuyersProductsRepo buyersProductsRepo, EntityMaker entityMaker, ProductsMapper productsMapper, BuyersProductsValidator validationRules)
        {
            _buyersProductsRepo = buyersProductsRepo;
            _entityMaker = entityMaker;
            _productsMapper = productsMapper;
            _buyersProductsValidator = validationRules;
        }

        public async Task<GetBuyersProductsResponse> GetConnectionService(GetBuyersProudctsRequest request)
        {
            var buyersProducts = await _buyersProductsRepo.GetConnection(request.ProductId, request.UserId);
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
        public async Task<CreateBuyersProductsResponse> CreateConnectionService(CreateBuyersProductsRequest request)
        {
            var newConnection = _entityMaker.RequestToNewBuyersProducts(request);
            var validation = _buyersProductsValidator.ValidateAndThrowAsync(newConnection);
            var addition = await _buyersProductsRepo.CreateConnection(newConnection);
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
        public async Task<DeleteBuyersProductsResponse> DeleteConnectionService(DeleteBuyersProductsRequest request)
        {
            var removal = await _buyersProductsRepo.DeleteConnection(request.ProductId, request.UserId);
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
        public async Task<UpdateBuyersProductsResponse> UpdateConnectionService(UpdateBuyersProductsRequest request)
        {
            var updatedConnection = _entityMaker.RequestToUpdatedBuyersProducts(request);
            var validation = _buyersProductsValidator.ValidateAndThrowAsync(updatedConnection);
            var update = await _buyersProductsRepo.UpdateConnection(updatedConnection);
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
