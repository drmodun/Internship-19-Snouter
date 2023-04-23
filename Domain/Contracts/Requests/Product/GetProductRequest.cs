using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Product
{
    public class GetProductRequest
    {
        public Guid Id { get; set; }
    }
}
