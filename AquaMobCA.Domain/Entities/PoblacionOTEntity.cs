using System.Collections.Generic;

namespace Domain.Entities
{
    public class PoblacionOTEntity : BaseEntity
    {
        public string Codigo { get; set; }

        public string Poblacion { get; set; }

        public ICollection<CalleOTEntity> Calles { get; set; }

        public ICollection<ZonaOTEntity> Zonas { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }

        public ICollection<InstalacionOTEntity> Instalaciones { get; set; }
    }
}
