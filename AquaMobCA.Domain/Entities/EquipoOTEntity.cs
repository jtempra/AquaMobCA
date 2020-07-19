using System.Collections.Generic;

namespace Domain.Entities
{
    public class EquipoOTEntity: BaseEntity
    {
        public string Equipo { get; set; }

        public string Observaciones { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }

        public SubinstalacionOTEntity Subinstalacion { get; set; }
    }
}
