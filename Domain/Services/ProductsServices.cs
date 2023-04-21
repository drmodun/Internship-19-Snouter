using Domain.Contracts.Requests.Product;
using Domain.Contracts.Response.BuyersProducts;
using Domain.Contracts.Response.Product;
using Domain.Mapper;
using Domain.Repositories;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductsServices
    {
        private readonly ProductRepo _productRepository;
        private readonly EntityMaker _entityMaker;
        public async Task<CreateProductResponse> CreateProductService(CreateProductRequest request)
        {
            var newProduct = _entityMaker.RequestToNewProduct(request);
            var categorySchema = newProduct.Category.Schema;
            var subCategorySchema = newProduct.SubCategory.Schema;
            bool valid = newProduct.ExtraProperties.IsValid(categorySchema);
            bool validSub = newProduct.SubProperties.IsValid(subCategorySchema);
            if (!valid || !validSub)
            {
                return new CreateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };

            };
            var addition = await _productRepository.AddProduct(newProduct);
            if (!addition)
            {
                return new CreateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };
            }
            var newDTO = ProductsMapper.ProductToDTO(newProduct);
            return new CreateProductResponse
            {
                Product = newDTO,
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };
        }
        public async Task<GetProductResponse> GetProductService(GetProductRequest request)
        {
            var product = await _productRepository.GetProductById(request.Id);
            if (product == null)
            {
                return new GetProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.NotFound
                };
            }
            return new GetProductResponse
            {
                Product = ProductsMapper.ProductToDTO(product),
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };
        }
        public async Task<GetAllProductsResponse> GetAllProductsService()
        {
            var products = await _productRepository.GetAllProducts();
            return new GetAllProductsResponse
            {
                Products = products.Select(ProductsMapper.ProductToDTO).ToList()
            };
        }
        public async Task<DeleteProductResponse> DeleteProductService(DeleteProductRequest request)
        {
            var removal = await _productRepository.DeleteProduct(request.Id);
            if (!removal)
            {
                return new DeleteProductResponse
                {
                    Status = System.Net.HttpStatusCode.NotFound,
                    Success = false,
                };
            }
            return new DeleteProductResponse
            {
                Status = System.Net.HttpStatusCode.OK,
                Success = true
            };
        }
        public async Task<UpdateProductResponse> UpdateProductService(UpdateProductRequest request)
        {
            var newProduct = _entityMaker.RequestToUpdatedProduct(request);
            var categorySchema = newProduct.Category.Schema;
            var subCategorySchema = newProduct.SubCategory.Schema;
            bool valid = newProduct.ExtraProperties.IsValid(categorySchema);
            bool validSub = newProduct.SubProperties.IsValid(subCategorySchema);
            if (!valid || !validSub)
            {
                return new UpdateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };

            };
            var removal = await _productRepository.DeleteProduct(request.Id);
            if (!removal)
            {
                return new UpdateProductResponse
                {
                    Status = System.Net.HttpStatusCode.NotFound,
                    Success = false,
                };
            }
            var addition = await _productRepository.AddProduct(newProduct);
            if (!addition)
            {
                return new UpdateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.Gone,
                    Success = false,
                };
            }
            return new UpdateProductResponse
            {
                Product = ProductsMapper.ProductToDTO(newProduct),
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };

        }
    }
}
