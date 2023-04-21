using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Country
{
    public class UpdateCountryRequest
    {
        public Guid Id { get; set; }
        public string? Slug { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
