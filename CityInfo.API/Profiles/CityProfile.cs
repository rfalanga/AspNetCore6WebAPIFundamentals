using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class CityProfile : Profile  // This Profile is an AutoMapper class
    {
        public CityProfile()
        {
            // AutoMapper's convention will map property names of the source object to the same property names on the destination object.
            // It will ignore null references from source to target/destination. If the object doesn't exist, it will be ignored.

            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
            CreateMap<Entities.City, Models.CityDto>();
        }
    }
}
