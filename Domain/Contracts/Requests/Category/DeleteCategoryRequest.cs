﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Category
{
    public class DeleteCategoryRequest
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
    }
}
