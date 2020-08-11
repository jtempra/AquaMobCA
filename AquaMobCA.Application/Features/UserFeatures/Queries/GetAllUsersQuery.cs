using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.UserFeatures.Queries
{
    public class GetAllUsersQuery : IRequest<PagedResponse<IEnumerable<GetAllUsersViewModel>>>
    {

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, PagedResponse<IEnumerable<GetAllUsersViewModel>>>
        
    {
        private readonly IGenericRepoAsync<UserEntity> _repo;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IGenericRepoAsync<UserEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }    
        public async Task<PagedResponse<IEnumerable<GetAllUsersViewModel>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllUsersParameter>(request);
            var user = await _repo.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var userViewModel = _mapper.Map<IEnumerable<GetAllUsersViewModel>>(user);
            
            return new PagedResponse<IEnumerable<GetAllUsersViewModel>>(userViewModel,validFilter.PageNumber,validFilter.PageSize);
        }
        
    }
}
