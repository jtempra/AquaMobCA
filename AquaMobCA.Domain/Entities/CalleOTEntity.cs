using System;
using System.Collections.Generic;
using System.Text;

namespace AquaMobCA.Domain.Entities
{
    public class CalleOTEntity: BaseEntity
    {
        public string Codigo { get; set; }

        public string Calle { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }
    }
}
