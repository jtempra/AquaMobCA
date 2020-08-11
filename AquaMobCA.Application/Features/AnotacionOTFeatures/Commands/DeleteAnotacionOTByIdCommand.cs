using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.UserFeatures.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.AnotacionOTFeatures.Commands
{
    class DeleteAnotacionOTByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteAnotacionOTByIdCommandHandler : IRequestHandler<DeleteAnotacionOTByIdCommand, int>
        {
            private readonly IGenericRepoAsync<AnotacionOTEntity> _repo;
            public DeleteAnotacionOTByIdCommandHandler(IGenericRepoAsync<AnotacionOTEntity> repo)
            {
                _repo = repo;
            }
            public async Task<int> Handle(DeleteAnotacionOTByIdCommand command, CancellationToken cancellationToken)
            {
                var anotacion = await _repo.GetByIdAsync(command.Id);
                if (anotacion == null) return default;
                await _repo.DeleteAsync(anotacion);

                return anotacion.Id;
            }
        }
    }
}
