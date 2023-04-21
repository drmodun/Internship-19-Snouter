using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Country
{
    public class GetCountryRequest
    {
        public Guid Id;
        public string? Slug;
    }
}
