using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enumerations;
using MediatR;

namespace API.Features.UserFeatures.Commands
{
    public class UpdateUserCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string PathFoto { get; set; }
        public TipoUsuario Rol { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
        {
            private readonly IGenericRepoAsync<UserEntity> _repo;
            public UpdateUserCommandHandler(IGenericRepoAsync<UserEntity> repo)
            {
                _repo = repo;
            }
            public async Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
            {
                var user = await _repo.GetByIdAsync(command.Id);

                if (user == null)
                {
                    return default;
                }
                else
                {
                    user.NIF = command.NIF;
                    user.Nombre = command.Nombre;
                    user.Apellidos = command.Apellidos;
                    user.Direccion = command.Direccion;
                    user.Movil = command.Movil;
                    user.Email = command.Email;
                    user.PathFoto = command.PathFoto;
                    user.Rol = command.Rol;
                    user.UserName = command.UserName;
                    user.Password = command.Password;

                    await _repo.UpdateAsync(user);

                    return user.Id;
                }
            }
        }
    }
}