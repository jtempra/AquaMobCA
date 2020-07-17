using System.Collections.Generic;

namespace Domain.Entities
{
    public class TipoOTEntity : BaseEntity
    {
        
        public string Tipo { get; set; }

        public string Descripcion { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }
    }
}
