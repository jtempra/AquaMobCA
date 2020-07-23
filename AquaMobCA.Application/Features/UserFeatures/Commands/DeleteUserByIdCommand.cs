using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.UserFeatures.Commands
{
    public class DeleteUserByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, int>
        {
            private readonly IGenericRepoAsync<UserEntity> _repo;
            public DeleteUserByIdCommandHandler(IGenericRepoAsync<UserEntity> repo)
            {
                _repo = repo;
            }
            public async Task<int> Handle(DeleteUserByIdCommand command, CancellationToken cancellationToken)
            {
                var user = await _repo.GetByIdAsync(command.Id);
                if (user == null) return default;
                await _repo.DeleteAsync(user);
                
                return user.Id;
            }
        }
    }
}
