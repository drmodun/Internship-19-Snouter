﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public ViewProfile Seller { get; set; }
        public ViewProfile Buyer { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public JObject ExtraProperties;
        public JObject SubProperties { get; set; }
    }
}