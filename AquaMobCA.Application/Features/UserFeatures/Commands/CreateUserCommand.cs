using Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enumerations;

namespace Application.Features.UserFeatures.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
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

        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
        {
            private readonly IGenericRepoAsync<UserEntity> _repo;

            public CreateUserCommandHandler(IGenericRepoAsync<UserEntity> repo)
            {
                _repo = repo;
            }

            public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
            {
                var user = new UserEntity();

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

                await _repo.AddAsync(user);
                return user.Id;
            }
        }
    }
}
