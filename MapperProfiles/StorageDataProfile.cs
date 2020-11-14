using AutoMapper;
using Entities = MPPIS.Domain.Entities;
using MPPIS.Dto;

namespace MPPIS.MapperProfiles
{
    public class StorageDataProfile : Profile
    {
        public StorageDataProfile()
        {
            CreateMap<StorageDataDto, Entities.StorageData>().ReverseMap()
                .ForMember(x => x.DayPrice, opt => opt.MapFrom(x => x.DayPriceId))
                .ForMember(x => x.User, opt => opt.MapFrom(x => x.UserId));

            CreateMap<AddStorageDataDto, Entities.StorageData>().ReverseMap()
                .ForMember(x => x.User, opt => opt.MapFrom(x => x.UserId));

        }
    }
}
