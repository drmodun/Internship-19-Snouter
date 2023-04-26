using Domain.Contracts.Requests.Product;
using Domain.Contracts.Response.Product;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;

namespace Domain.Services.Implmentations
{
    public class ProductsServices : IProductsServices
    {
        private readonly IProductRepo _productRepository;
        private readonly EntityMaker _entityMaker;
        private readonly IProductsMapper _productsMapper;
        private readonly ProductsValidator _productsValidator;

        public ProductsServices(IProductRepo productRepository, EntityMaker entityMaker, IProductsMapper productsMapper, ProductsValidator validationRules)
        {
            _productRepository = productRepository;
            _entityMaker = entityMaker;
            _productsMapper = productsMapper;
            _productsValidator = validationRules;
        }

        public async Task<CreateProductResponse> CreateProductService(CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            var newProduct = _entityMaker.RequestToNewProduct(request);
            await _productsValidator.ValidateAndThrowAsync(newProduct);
            if (newProduct == null)
            {
                return new CreateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };

            };
            var addition = await _productRepository.AddProduct(newProduct, cancellationToken);
            if (!addition)
            {
                return new CreateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };
            }
            var newDTO = _productsMapper.ProductToDTO(newProduct);
            return new CreateProductResponse
            {
                Product = newDTO,
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };
        }
        public async Task<GetProductResponse> GetProductService(GetProductRequest request, CancellationToken cancellationToken = default)
        {
            var product = await _productRepository.GetProductById(request.Id, cancellationToken);
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
                Product = _productsMapper.ProductToDTO(product),
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };
        }
        public async Task<GetAllProductsResponse> GetAllProductsService()
        {
            var products = await _productRepository.GetAllProducts();
            return new GetAllProductsResponse
            {
                Products = products.Select(_productsMapper.ProductToDTO).ToList()
            };
        }
        public async Task<DeleteProductResponse> DeleteProductService(DeleteProductRequest request, CancellationToken cancellationToken = default)
        {
            var removal = await _productRepository.DeleteProduct(request.Id, cancellationToken);
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
        public async Task<UpdateProductResponse> UpdateProductService(UpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            var newProduct = _entityMaker.RequestToUpdatedProduct(request);
            await _productsValidator.ValidateAndThrowAsync(newProduct);
            if (newProduct == null)
            {
                return new UpdateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                };

            };
            var update = await _productRepository.UpdateProduct(newProduct, cancellationToken);
            if (!update)
            {
                return new UpdateProductResponse
                {
                    Product = null,
                    Status = System.Net.HttpStatusCode.NotFound,
                    Success = false,
                };
            }
            return new UpdateProductResponse
            {
                Product = _productsMapper.ProductToDTO(newProduct),
                Status = System.Net.HttpStatusCode.OK,
                Success = true,
            };

        }
    }
}
