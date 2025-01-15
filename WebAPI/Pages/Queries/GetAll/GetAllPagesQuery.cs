using MediatR;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Queries.GetAll
{
    public class GetAllPagesQuery : IRequest<IEnumerable<Page>>
    {

    }
}
