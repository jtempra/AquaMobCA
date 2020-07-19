using System.Collections.Generic;

namespace Domain.Entities
{
    public class TipoOrigenIncidenciaEntity : BaseEntity
    {
        public string OrigenIncidencia { get; set; }
        public string Observaciones { get; set; }

        public ICollection<IncidenciaEntity> Incidencias { get; set; }
    }
}
