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
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Guid> Locations { get; set; }
        public string Image { get; set; }

    }
}
