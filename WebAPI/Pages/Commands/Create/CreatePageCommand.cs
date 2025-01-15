using MediatR;

namespace WebAPI.Pages.Commands.Create
{
    public class CreatePageCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
