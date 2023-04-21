using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Subcategory
{
    public class UpdateSubcategoryReponse
    {
        public SubCategoryDTO? SubCategory { get; set; }
        public bool Success;
        public HttpStatusCode Status;
    }
}
