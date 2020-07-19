using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Enumerations;

namespace Domain.Entities
{
    public class LecturaEntity : BaseEntity
    {
        public int NumeroContrato { get; set; }

        public string NombreAbonado { get; set; }

        public string MovilAbonado { get; set; }

        public string EmailAbonado { get; set; }

        public string DireccionSuministro { get; set; }

        public string PoblacionSuministro { get; set; }

        public string OrdenRutaLectura { get; set; }

        public string UbicacionContador { get; set; }

        public string NumeroContador { get; set; }

        public string NumeroContadorNuevo { get; set; }

        public string RutaLecturaNueva { get; set; }

        public string OrdenRutaLecturaNueva { get; set; }

        public Double LecturaAnterior { get; set; }

        public Double LecturaActual { get; set; }

        public Double LecturaNuevo { get; set; }

        public DateTime FechaLecturaAnterior { get; set; }

        public DateTime FechaLecturaAnteriorLocal => FechaLecturaAnterior.ToLocalTime();

        public DateTime FechaLecturaActual { get; set; }

        public DateTime FechaLecturaActualLocal => FechaLecturaActual.ToLocalTime();

        public DateTime? FechaLecturaNuevo { get; set; }

        public DateTime? FechaLecturaNuevoLocal => FechaLecturaNuevo.HasValue ? FechaLecturaNuevo.Value.ToLocalTime() : FechaLecturaNuevo;

        public TipoSituacionLectura SituacionLectura { get; set; }

        public TipoIncidenciaLecturaEntity IncidenciaLectura { get; set; }

        public TipoIncidenciaContador IncidenciaContador { get; set; }

        public double ConsumoAnterior { get; set; }

        public double PromedioConsumo { get; set; }

        public string ObservacionesLectura { get; set; }

        public string ObservacionesSuministro { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        public int Periodo { get; set; }

        public string Codigo1 { get; set; }

        public string Codigo2 { get; set; }

        public string Codigo3 { get; set; }

        public RutaLecturaEntity Ruta { get; set; }

        public ICollection<FotoEntity> Fotos { get; set; }

        public UserEntity Operario { get; set; }
    }
}
