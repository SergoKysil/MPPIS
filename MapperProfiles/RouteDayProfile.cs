using AutoMapper;
using Entities = MPPIS.Domain.Entities;
using MPPIS.Dto;

namespace MPPIS.MapperProfiles
{
    public class RouteDayProfile : Profile
    {
        public RouteDayProfile()
        {
            CreateMap<RouteDayDto, Entities.RouteDay>().ReverseMap();
        }
    }
}
