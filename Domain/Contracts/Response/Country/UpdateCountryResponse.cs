﻿using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Country
{
    public class UpdateCountryResponse
    {
        public CountryDTO? Country { get; set; }
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
