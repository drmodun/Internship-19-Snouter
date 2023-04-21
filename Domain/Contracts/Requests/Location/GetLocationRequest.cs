using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Location
{
    public class GetLocationRequest
    {
        public Guid Id { get; set; }
        public string? Slug { get; set; }
    }
}
