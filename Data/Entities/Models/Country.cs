using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Location> Locations { get; set; }

        public Blob Image { get; set; } 
    }
}
