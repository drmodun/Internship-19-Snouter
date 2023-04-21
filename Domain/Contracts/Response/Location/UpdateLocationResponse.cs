﻿using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Location
{
    public class UpdateLocationResponse
    {
        public LocationView? Location;
        public bool ? Success;
        public HttpStatusCode Status;
    }
}