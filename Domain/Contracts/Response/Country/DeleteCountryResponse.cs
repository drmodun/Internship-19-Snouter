using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Country
{
    public class DeleteCountryResponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
