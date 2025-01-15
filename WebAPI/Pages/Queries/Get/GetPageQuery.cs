using MediatR;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Queries.Get
{
    public class GetPageQuery : IRequest<Page>
    {
        public Guid Guid { get; set; }

        public GetPageQuery(Guid guid)
        {
            Guid = guid;
        }
    }
}
