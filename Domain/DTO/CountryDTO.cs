using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class CountryDTO
    {
        public Guid Id;
        public string Name;
        public List<LocationView> Locations;
        public string Image;

    }
}
