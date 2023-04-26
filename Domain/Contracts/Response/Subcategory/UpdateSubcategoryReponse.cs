using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Subcategory
{
    public class UpdateSubcategoryReponse
    {
        public SubCategoryDTO? SubCategory { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
