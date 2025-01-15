using MediatR;

namespace WebAPI.Pages.Commands.Delete
{
    public class DeletePageCommand : IRequest<bool>
    {
        public Guid Guid { get; set; }
        public DeletePageCommand(Guid guid)
        {
            Guid = guid;
        }
    }
}
