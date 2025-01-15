using AutoMapper;
using MediatR;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Commands.Create
{
    public class CreatePageCommandHandler : IRequestHandler<CreatePageCommand, Guid>
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public CreatePageCommandHandler(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePageCommand request, CancellationToken cancellationToken)
        {
            Page page = _mapper.Map<Page>(request);
            page.Guid = Guid.NewGuid();
            page.CreatedAt = DateTime.UtcNow;
            page.UpdatedAt = DateTime.UtcNow;
            await _repository.AddAsync(page);
            return page.Guid;
        }
    }
}
