﻿using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Category
{
    public class DeleteCategoryResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
