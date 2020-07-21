using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace API.Features.UserFeatures.Queries
{
    public class GetUserByIdQuery:IRequest<UserEntity>
    {
        public int Id { get; set; }
        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserEntity>
        {
            private readonly IGenericRepoAsync<UserEntity> _repo;
            public GetUserByIdQueryHandler(IGenericRepoAsync<UserEntity> repo)
            {
                _repo = repo;
            }
            public async Task<UserEntity> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
            {
                var user = await _repo.GetByIdAsync(query.Id);
                if (user == null) return null;
                return user;
            }
        }
    }
}
