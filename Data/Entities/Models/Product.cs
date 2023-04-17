﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

namespace Data.Entities.Models
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid Seller { get; set; }
        public List<string> Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<ProductsSubCategories> ProductsSubCategories;
    }
}
