﻿using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.SubCategory
{
    public class GetSubcatgoryResponse
    {
        public SubCategoryDTO SubCategory { get; set; }
        public bool Success;
        public HttpStatusCode StatusCode;
    }
}