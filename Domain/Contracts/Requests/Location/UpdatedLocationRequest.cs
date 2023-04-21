﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Location
{
    public class UpdatedLocationRequest
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
