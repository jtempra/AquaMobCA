using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using AquaMob.Core.Enumerations;

namespace AquaMobCA.Domain.Entities
{
    public class UserEntity :BaseEntity
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
        public string NombreCompleto => $"{Nombre} {Apellidos}";
        public ICollection<LecturaEntity> Lecturas { get; set; }

        public ICollection<IncidenciaEntity> Incidencias { get; set; }

        public ICollection<OTEntity> OrdenesTrabajoCreadas { get; set; }

        public ICollection<OTEntity> OrdenesTrabajoGestionadas { get; set; }
    }
}
