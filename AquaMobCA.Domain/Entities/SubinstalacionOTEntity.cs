using System.Collections.Generic;

namespace Domain.Entities
{
    public class SubinstalacionOTEntity : BaseEntity
    {
        public string Subinstalacion { get; set; }

        public string Observaciones { get; set; }

        public InstalacionOTEntity Instalacion { get; set; }

        public ICollection<EquipoOTEntity> Equipos { get; set; }
    }
}
