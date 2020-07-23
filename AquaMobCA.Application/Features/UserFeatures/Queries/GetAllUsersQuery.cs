using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.UserFeatures.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserEntity>>
    {
        public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserEntity>>
        {
            private readonly IGenericRepoAsync<UserEntity> _repo;
            public GetAllUsersQueryHandler(IGenericRepoAsync<UserEntity> repo)
            {
                _repo = repo;
            }
            public async Task<IEnumerable<UserEntity>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken)
            {
                var userList = await _repo.GetAllAsync();
                if (userList == null)
                {
                    return null;
                }
                return userList;
            }
        }
    }
}
