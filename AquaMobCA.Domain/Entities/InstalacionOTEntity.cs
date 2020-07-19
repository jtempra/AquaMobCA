using System.Collections.Generic;

namespace Domain.Entities
{
    public class InstalacionOTEntity : BaseEntity
    {
        public string Instalacion { get; set; }

        public string Observaciones { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public ICollection<SubinstalacionOTEntity> Subinstalaciones { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }
    }
}
