using AutoMapper;
using MPPIS.Dto;
using Entities = MPPIS.Domain.Entities;

namespace MPPIS.MapperProfiles
{
    public class DayPriceProfile : Profile
    {
        public DayPriceProfile()
        {
            CreateMap<DayPriceDto, Entities.DayPrice>().ReverseMap()
                .ForMember(x => x.StorageData, opt => opt.MapFrom(x => x.StorageData));

            CreateMap<AddDayPriceDto, Entities.DayPrice>().ReverseMap();
        }
    }
}
