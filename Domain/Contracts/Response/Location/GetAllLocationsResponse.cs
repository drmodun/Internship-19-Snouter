using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Location
{
    public class GetAllLocationsResponse
    {
        public List<LocationView> Locations { get; set; }
    }
}
