using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.Product
{
    public class GetProductsResponse
    {
        public List<ProductDTO> Products;
    }
}
