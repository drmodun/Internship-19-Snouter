using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper.Interfaces
{
    public interface ILocationMapper
    {
        public LocationView LocationToDTO(Location location);
        public CountryDTO CountryToDTO(Country country);

    }
}
