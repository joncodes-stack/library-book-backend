using AutoMapper;
using PersonalLibrary.Domain.Dtos;
using PersonalLibrary.Domain.Entities;

namespace LibraryBook.Ioc
{
    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {

            CreateMap<RegisterUserDto, User>()
            .ForMember(dest => dest.Password, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<Item, ItemDto>().ReverseMap();

            CreateMap<User, UserTokenDto>();
        }
    }
}
