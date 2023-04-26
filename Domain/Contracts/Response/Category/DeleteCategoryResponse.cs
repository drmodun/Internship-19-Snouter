using System.Net;

namespace Domain.Contracts.Response.Category
{
    public class DeleteCategoryResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
