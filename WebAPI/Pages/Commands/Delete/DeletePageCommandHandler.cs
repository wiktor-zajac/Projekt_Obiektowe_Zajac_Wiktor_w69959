using AutoMapper;
using MediatR;
using WebAPI.Pages.Commands.Create;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Commands.Delete
{
    public class DeletePageCommandHandler : IRequestHandler<DeletePageCommand, bool>
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public DeletePageCommandHandler(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeletePageCommand request, CancellationToken cancellationToken)
        {
            Page page = await _repository.GetByIdAsync(request.Guid);

            if (page is null)
                return false;

            _repository.Remove(page);

            return true;
        }
    }
}
