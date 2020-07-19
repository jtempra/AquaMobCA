using System.Collections.Generic;

namespace Domain.Entities
{
    public class TipoIncidenciaEntity : BaseEntity
    {
        public string Codigo { get; set; }

        public string Tipo { get; set; }

        public string Observaciones { get; set; }

        public ICollection<IncidenciaEntity> Incidencias { get; set; }
    }
}
