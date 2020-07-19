using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class HistoricoLecturasEntity : BaseEntity
    {
        public int NumeroContrato { get; set; }

        public int Periodo { get; set; }
        public double Lectura { get; set; }

        public DateTime FechaLectura { get; set; }

        public DateTime FechaLecturaLocal => FechaLectura.ToLocalTime();

        public double ConsumoLectura { get; set; }
        public double ConsumoImputado { get; set; }
        public double ConsumoEstimado { get; set; }
        public double ConsumoFacturado { get; set; }
        public TipoIncidenciaLecturaEntity IncidenciaLectura { get; set; }
    }
}
