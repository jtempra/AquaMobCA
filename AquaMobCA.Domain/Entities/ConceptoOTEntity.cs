using System;
using System.Collections.Generic;
using System.Text;
using AquaMob.Core.Enumerations;

namespace AquaMobCA.Domain.Entities
{
    public class ConceptoOTEntity: BaseEntity
    {
        public string Codigo { get; set; }

        public string Concepto { get; set; }

        public TipoConceptoOT Tipo { get; set; }

        public ICollection<DetalleOTEntity> DetallesOrdenTrabajo { get; set; }
    }
}
