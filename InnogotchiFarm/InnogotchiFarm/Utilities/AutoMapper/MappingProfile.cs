using AutoMapper;
using InnogotchiFarm.Data.Models;
using InnogotchiFarm.DataTransferObjects;

namespace InnogotchiFarm.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
