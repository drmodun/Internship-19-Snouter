using System.Net;

namespace Domain.Contracts.Response.Subcategory
{
    public class DeleteSubCategoryResponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
