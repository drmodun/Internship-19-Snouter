using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.SubCategory
{
    public class GetSubcatgoryResponse
    {
        public SubCategoryDTO SubCategory { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
