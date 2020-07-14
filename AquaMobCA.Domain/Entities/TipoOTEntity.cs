using System;
using System.Collections.Generic;
using System.Text;

namespace AquaMobCA.Domain.Entities
{
    public class TipoOTEntity : BaseEntity
    {
        
        public string Tipo { get; set; }

        public string Descripcion { get; set; }

        public ICollection<OTEntity> OrdenesTrabajo { get; set; }
    }
}
