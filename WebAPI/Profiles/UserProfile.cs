using AutoMapper;
using WebAPI.Users.Models;

namespace WebAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegisterDto, User>();
            CreateMap<UserLoginDto, User>();
        }
    }
}
