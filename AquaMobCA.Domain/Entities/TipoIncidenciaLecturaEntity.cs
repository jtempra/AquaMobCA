using System.Collections.Generic;

namespace Domain.Entities
{
    public class TipoIncidenciaLecturaEntity : BaseEntity
    {
        public string Codigo { get; set; }
        public string Incidencia { get; set; }
        public string Observaciones { get; set; }
        public ICollection<LecturaEntity> Lecturas { get; set; }
    }
}
