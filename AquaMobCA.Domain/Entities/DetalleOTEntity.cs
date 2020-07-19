using System;

namespace Domain.Entities
{
    public class DetalleOTEntity : BaseEntity
    {
        public OTEntity OrdenTrabajo { get; set; }

        public ConceptoOTEntity Concepto { get; set; }

        public UserEntity Operario { get; set; }

        public double Cantidad { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaLocal => Fecha.ToLocalTime();

        public Boolean Validado { get; set; }
    }
}
