using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Product
{
    public class DeleteProductRequest
    {
        public Guid Id { get; set; }
        public string? Slug;
    }
}
