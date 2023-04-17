﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

namespace Data.Entities.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid SellerId{ get; set; }

        public DateTime Created { get; set; }
        public User? Seller { get; set; }

        public Guid BuyerId { get; set; }
        public User Buyer { get; set; }


        public List<string> Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

        public Dictionary<JSchema, object> ExtraProperties = new();
        public Dictionary<JSchema, object> SubProperties = new();


    }
}
