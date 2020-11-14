using AutoMapper;
using MPPIS.Domain.Entities;
using MPPIS.Dto;

namespace MPPIS.MapperProfiles
{
    public class RouteDayProfile : Profile
    {
        public RouteDayProfile()
        {
            CreateMap<RouteDay, RouteDayDto>().ReverseMap();
        }
    }
}
