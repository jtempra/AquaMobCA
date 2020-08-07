using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enumerations;

namespace Application.Features.UserFeatures.Queries
{
    class GetAllUsersViewModel
    {
        public int Id { get; set; }
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public TipoUsuario Rol { get; set; }
    }
}
