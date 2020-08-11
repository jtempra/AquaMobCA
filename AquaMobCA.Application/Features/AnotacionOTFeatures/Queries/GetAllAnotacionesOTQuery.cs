using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.UserFeatures.Queries;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.AnotacionOTFeatures.Queries
{

    public class GetAllAnotacionesOTQuery : IRequest<PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>>
    {

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllAnotacionesOTQueryHandler : IRequestHandler<GetAllAnotacionesOTQuery, PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>>
    {
        private readonly IGenericRepoAsync<AnotacionOTEntity> _repo;
        private readonly IMapper _mapper;
        public GetAllAnotacionesOTQueryHandler(IGenericRepoAsync<AnotacionOTEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        
        public async Task<PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>> Handle(GetAllAnotacionesOTQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllAnotacionesOTParameter>(request);
            var anotacion = await _repo.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var anotacionViewModel = _mapper.Map<IEnumerable<GetAllAnotacionesOTViewModel>>(anotacion);

            return new PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>(anotacionViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
