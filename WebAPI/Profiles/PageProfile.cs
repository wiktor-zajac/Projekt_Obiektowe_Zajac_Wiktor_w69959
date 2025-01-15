using AutoMapper;
using WebAPI.Pages.Commands.Create;
using WebAPI.Pages.Commands.Update;
using WebAPI.Pages.Models;

namespace WebAPI.Profiles
{
    public class PageProfile : Profile
    {
        public PageProfile()
        {
            CreateMap<CreatePageCommand, Page>();
            CreateMap<UpdatePageCommand, Page>();
        }
    }
}
