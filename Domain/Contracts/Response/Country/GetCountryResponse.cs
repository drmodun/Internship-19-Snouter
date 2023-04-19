using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.Country
{
    public class GetCountryResponse
    {
        public bool ? Success { get; set; }
        public CountryDTO Country;
        public HttpStatusCode StatusCode { get; set; }
    }
}
