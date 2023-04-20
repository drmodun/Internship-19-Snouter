using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Location
{
    public class UpdatedLocationRequest
    {
        public Guid Id;
        public Guid CountryId;
        public string Name;
        public decimal Latitude;
        public decimal Longitude;
    }
}
