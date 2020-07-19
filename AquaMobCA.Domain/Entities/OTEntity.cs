using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Enumerations;

namespace Domain.Entities
{
    public class OTEntity : BaseEntity
    {
        public TipoOTEntity Tipo { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaLocal => Fecha.ToLocalTime();

        public UserEntity Responsable { get; set; }

        public UserEntity Creador { get; set; }

        public TipoSituacionOT Situacion { get; set; }

        public DateTime FechaSituacion { get; set; }

        public DateTime FechaSituacionLocal => FechaSituacion.ToLocalTime();

        public string Descripcion { get; set; }

        public string Trabajos { get; set; }

        public ICollection<AnotacionOTEntity> Anotaciones { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public CalleOTEntity Calle { get; set; }

        public ZonaOTEntity Zona { get; set; }

        public string Direccion { get; set; }

        public string DireccionAdicional { get; set; }

        public int NumeroContrato { get; set; }

        public string NombreAbonado { get; set; }

        public string MovilCliente { get; set; }

        public string EMailCliente { get; set; }

        public PrioridadOT Prioridad { get; set; }

        public double? Latitud { get; set; }

        public double? Longitud { get; set; }

        public InstalacionOTEntity Instalacion { get; set; }

        public SubinstalacionOTEntity SubInstalacion { get; set; }

        public EquipoOTEntity Equipo { get; set; }

        public Boolean CreadaApp { get; set; }

        public Boolean Recurrente { get; set; }

        public Boolean Generica { get; set; }

        public Boolean PendienteObras { get; set; }

        public ICollection<DetalleOTEntity> DetallesOrdenTrabajo { get; set; }

        public ICollection<FotoEntity> Fotos { get; set; }
    }
}
