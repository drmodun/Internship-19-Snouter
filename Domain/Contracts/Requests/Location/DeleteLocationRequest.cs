using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Location
{
    public class DeleteLocationRequest
    {
        public Guid Id;
        public string? Slug;
    }
}
