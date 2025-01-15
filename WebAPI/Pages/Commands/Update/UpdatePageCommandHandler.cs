using AutoMapper;
using MediatR;
using WebAPI.Pages.Commands.Create;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Commands.Update
{
    public class UpdatePageCommandHandler : IRequestHandler<UpdatePageCommand, bool>
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public UpdatePageCommandHandler(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdatePageCommand request, CancellationToken cancellationToken)
        {
            Page page = await _repository.GetByIdAsync(request.Guid);

            if (page is null)
                return false;
            
            page.Name = request.Name;
            page.Content = request.Content;
            page.UpdatedAt = DateTime.UtcNow;
            _repository.Update(page);

            return true;
        }
    }
}
