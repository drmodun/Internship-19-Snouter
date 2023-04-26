using Domain.DTO;

namespace Domain.Contracts.Response.Location
{
    public class GetAllLocationsResponse
    {
        public List<LocationView> Locations { get; set; }
    }
}
