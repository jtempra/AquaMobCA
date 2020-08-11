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
    class CreateAnotacionOTCommand : IRequest<int>
    {
        public string Anotacion { get; set; }
        public DateTime Fecha { get; set; }
        public UserEntity Operario { get; set; }
        public OTEntity OrdenTrabajo { get; set; }

        public class CreateAnotacionOTCommandHandler : IRequestHandler<CreateAnotacionOTCommand, int>
        {
            private readonly IGenericRepoAsync<AnotacionOTEntity> _repo;

            public CreateAnotacionOTCommandHandler(IGenericRepoAsync<AnotacionOTEntity> repo)
            {
                _repo = repo;
            }

            public async Task<int> Handle(CreateAnotacionOTCommand command, CancellationToken cancellationToken)
            {
                var anotacion = new AnotacionOTEntity();

                anotacion.Anotacion = command.Anotacion;
                anotacion.Fecha = command.Fecha;
                anotacion.Operario = command.Operario;
                anotacion.OrdenTrabajo = command.OrdenTrabajo;


                await _repo.AddAsync(anotacion);
                return anotacion.Id;
            }
        }
    }
}
