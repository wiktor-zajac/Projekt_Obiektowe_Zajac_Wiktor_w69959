using AutoMapper;
using MediatR;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Queries.Get
{
    public class GetPageQueryHandler : IRequestHandler<GetPageQuery, Page>
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public GetPageQueryHandler(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Page> Handle(GetPageQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Guid);
        }
    }
}
