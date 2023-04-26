using Data.Entities.Models;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper.Interfaces
{
    internal interface IProductsMapper
    {
        public ProductDTO ProductToDTO(Product product);
        public BuyersProductsView BuyersProductsToDto(BuyersProducts buyersProducts);
    }
}
