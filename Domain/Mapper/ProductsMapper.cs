using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper
{
    public class ProductsMapper
    {
        public static UserDTO MapUserToDTO(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                isAdmin = user.isAdmin,
                Name = user.Name,
                Email = user.Email,
                Address = user.Address,
                ListedProducts = user.ListedProducts.Select(MapProductToDTO).ToList(),
                BoughtProducts = user.BoughtProducts.Select(MapProductToDTO).ToList()

            };
        }

        public static ProductDTO MapProductToDTO(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category,
                SubCategory = product.SubCategory,
                Seller = MapUserToDTO(product.Seller),
                Buyer = MapUserToDTO(product.Buyer),
                ExtraProperties = product.ExtraProperties
            };
        }

       

        public static Product MapDTOToProduct(ProductDTO productDTO)
        {
            return new Product
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Category = productDTO.Category,
                SubCategory = productDTO.SubCategory,
                Seller = MapDTOToUser(productDTO.Seller),
                Buyer = MapDTOToUser(productDTO.Buyer),
                ExtraProperties = productDTO.ExtraProperties
            };
        }

        public static User MapDTOToUser(UserDTO userDTO)
        {
            return new User
            {
                Id = userDTO.Id,
                isAdmin = userDTO.isAdmin,
                Name = userDTO.Name,
                Email = userDTO.Email,
                Address = userDTO.Address,
                ListedProducts = userDTO.ListedProducts.Select(MapDTOToProduct).ToList(),
                BoughtProducts = userDTO.BoughtProducts.Select(MapDTOToProduct).ToList()
            };
        }

        public static List<ProductDTO> MapProductsToDTO(List<Product> products)
        {
            return products.Select(MapProductToDTO).ToList();
        }

        public static List<Product> MapDTOToProducts(List<ProductDTO> productDTOs)
        {
            return productDTOs.Select(MapDTOToProduct).ToList();
        }

    }
}
