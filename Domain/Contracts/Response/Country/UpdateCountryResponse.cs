using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Country
{
    public class UpdateCountryResponse
    {
        public CountryDTO? Country { get; set; }
        public bool ? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
