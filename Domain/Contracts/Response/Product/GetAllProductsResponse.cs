using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Product
{
    public class GetAllProductsResponse
    {
        public List<ProductDTO> Products { get; set; }
    }
}
