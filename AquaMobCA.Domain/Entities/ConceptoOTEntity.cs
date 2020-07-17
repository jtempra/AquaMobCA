using System.Collections.Generic;
using Domain.Enumerations;

namespace Domain.Entities
{
    public class ConceptoOTEntity: BaseEntity
    {
        public string Codigo { get; set; }

        public string Concepto { get; set; }

        public TipoConceptoOT Tipo { get; set; }

        public ICollection<DetalleOTEntity> DetallesOrdenTrabajo { get; set; }
    }
}
