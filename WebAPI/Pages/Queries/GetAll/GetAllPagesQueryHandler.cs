using AutoMapper;
using MediatR;
using WebAPI.Pages.Models;

namespace WebAPI.Pages.Queries.GetAll
{
    public class GetAllPagesQueryHandler : IRequestHandler<GetAllPagesQuery, IEnumerable<Page>>
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public GetAllPagesQueryHandler(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<Page>> Handle(GetAllPagesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
