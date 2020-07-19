using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Enumerations;

namespace Domain.Entities
{
    public class RutaLecturaEntity : BaseEntity
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int NumeroLecturas { get; set; }
        public int NumeroLeidas { get; set; }

        public TipoSituacionRutaLectura Situacion { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaInicioLocal => FechaInicio.HasValue ? FechaInicio.Value.ToLocalTime() : FechaInicio;

        public DateTime? FechaFin { get; set; }

        public DateTime? FechaFinLocal => FechaFin.HasValue ? FechaFin.Value.ToLocalTime() : FechaFin;

        public ICollection<LecturaEntity> Lecturas { get; set; }
    }
}
