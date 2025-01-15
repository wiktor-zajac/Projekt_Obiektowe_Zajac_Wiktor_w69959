using MediatR;

namespace WebAPI.Pages.Commands.Update
{
    public class UpdatePageCommand : IRequest<bool>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
