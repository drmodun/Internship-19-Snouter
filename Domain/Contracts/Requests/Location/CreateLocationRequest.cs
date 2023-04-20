using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Location
{
    public class CreateLocationRequest
    {
        public Guid Id;
        public string Name;
        public Guid CountryId;
        public decimal Latitude;
        public decimal Longitude;
    }
}
