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
    class UpdateAnotacionOTCommand : IRequest<int>
    {
        public string Anotacion { get; set; }
        public DateTime Fecha { get; set; }
        public UserEntity Operario { get; set; }

        public class UpdateAnotacionOTCommandHandler : IRequestHandler<UpdateAnotacionOTCommand, int>
        {
            private readonly IGenericRepoAsync<AnotacionOTEntity> _repo;

            public UpdateAnotacionOTCommandHandler(IGenericRepoAsync<AnotacionOTEntity> repo)
            {
                _repo = repo;
            }

            public async Task<int> Handle(UpdateAnotacionOTCommand command, CancellationToken cancellationToken)
            {
                var anotacion = new AnotacionOTEntity();

                anotacion.Anotacion = command.Anotacion;
                anotacion.Fecha = command.Fecha;
                anotacion.Operario = command.Operario;
                
                await _repo.AddAsync(anotacion);
                return anotacion.Id;
            }
        }
    }
}
