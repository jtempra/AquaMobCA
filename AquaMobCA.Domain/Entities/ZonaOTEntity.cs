using System;
using System.Collections.Generic;
using System.Text;

namespace AquaMobCA.Domain.Entities
{
    public class ZonaOTEntity : BaseEntity
    {
        public string Codigo { get; set; }

        public string Zona { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }
    }
}
