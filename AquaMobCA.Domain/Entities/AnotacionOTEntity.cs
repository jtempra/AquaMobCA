using System;
using System.Collections.Generic;
using System.Text;

namespace AquaMobCA.Domain.Entities
{
    public class AnotacionOTEntity : BaseEntity
    {
        public string Anotacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaLocal => Fecha.ToLocalTime();
        public UserEntity Operario { get; set; }
        public OTEntity OrdenTrabajo { get; set; }
    }
}
