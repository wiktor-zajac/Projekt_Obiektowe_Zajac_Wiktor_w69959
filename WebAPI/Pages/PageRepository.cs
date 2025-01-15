using Microsoft.EntityFrameworkCore;
using WebAPI.Generic.Repositories;
using WebAPI.Pages.Models;

namespace WebAPI.Pages
{
    public class PageRepository : Repository<Page>, IPageRepository
    {
        public PageRepository(WebAPIContext context) : base(context)
        {
        }
    }
}
