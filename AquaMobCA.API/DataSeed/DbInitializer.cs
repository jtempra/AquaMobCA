using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enumerations;
using Infraestructure.Persistence.DataContext;

namespace API.DataSeed
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context, IServiceProvider services)
        {
            
            context.Database.EnsureCreated();

            // usuarios

            if (!context.Usuarios.Any())
            {
                context.Usuarios.Add(new UserEntity()
                {
                    NIF = "11223344A",
                    Nombre = "Josep",
                    Apellidos = "Temprà Cor",
                    Direccion = "Carrer Trobadiners, 40",
                    Movil = "615051815",
                    Email = "jtempra@anoiant.com",
                    PathFoto = "c:\\fotos\\jt.jpg",
                    Rol = TipoUsuario.Administrador,
                    UserName = "jtempra",
                    Password = "123456",
                    Lecturas = new List<LecturaEntity>(),
                    Incidencias = new List<IncidenciaEntity>(),
                    OrdenesTrabajoCreadas = new List<OTEntity>(),
                    OrdenesTrabajoGestionadas = new List<OTEntity>()
                });
                context.Usuarios.Add(new UserEntity()
                {
                    NIF = "55667788B",
                    Nombre = "Ahmed",
                    Apellidos = "Al Azred",
                    Direccion = "Carrer Allah, 3-2-1",
                    Movil = "600112233",
                    Email = "aaa@aljazira.com",
                    PathFoto = "c:\\fotos\\aaa.jpg",
                    Rol = TipoUsuario.Lector,
                    UserName = "Ahmed",
                    Password = "123456",
                    Lecturas = new List<LecturaEntity>(),
                    Incidencias = new List<IncidenciaEntity>(),
                    OrdenesTrabajoCreadas = new List<OTEntity>(),
                    OrdenesTrabajoGestionadas = new List<OTEntity>()
                });
                context.Usuarios.Add(new UserEntity()
                {
                    NIF = "99009900X",
                    Nombre = "Joan",
                    Apellidos = "Manges",
                    Direccion = "Carrer de la frontera, 124",
                    Movil = "600234532",
                    Email = "jm@gmail.com",
                    PathFoto = "c:\\fotos\\jm.jpg",
                    Rol = TipoUsuario.Operario,
                    UserName = "jmanges",
                    Password = "123456",
                    Lecturas = new List<LecturaEntity>(),
                    Incidencias = new List<IncidenciaEntity>(),
                    OrdenesTrabajoCreadas = new List<OTEntity>(),
                    OrdenesTrabajoGestionadas = new List<OTEntity>()
                });
            }

            // OT

            if (!context.OrdenesTrabajo.Any())
            {
                context.OrdenesTrabajo.Add(new OTEntity()
                {
                    Tipo = new TipoOTEntity(),
                    Fecha = DateTime.Today,
                    Responsable = new UserEntity(),
                    Creador = new UserEntity(),
                    Situacion = TipoSituacionOT.Pendiente,
                    FechaSituacion = DateTime.Today,
                    Descripcion = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                    Trabajos = "BBBBBBBBBBBBBBBBBBB",
                    Anotaciones = new List<AnotacionOTEntity>(),
                    Poblacion = new PoblacionOTEntity(),
                    Calle = new CalleOTEntity(),
                    Zona = new ZonaOTEntity(),
                    Direccion = "dddddddddddddddddddddddddddddd",
                    DireccionAdicional = "eeeeeeeeeeeeeeeeeeeeeeeeeeeee",
                    NumeroContrato = 123456,
                    NombreAbonado = "pepito de los palotes",
                    MovilCliente = "600112233",
                    EMailCliente = "pp@terra.es",
                    Prioridad = PrioridadOT.Normal,
                    Latitud = 41.45545,
                    Longitud = 53.65756,
                    Instalacion = new InstalacionOTEntity(),
                    SubInstalacion = new SubinstalacionOTEntity(),
                    Equipo = new EquipoOTEntity(),
                    CreadaApp = false,
                    Recurrente = false,
                    Generica = false,
                    PendienteObras = true,
                    DetallesOrdenTrabajo = new List<DetalleOTEntity>(),
                    Fotos = new List<FotoEntity>()
                });
            }


            context.SaveChanges();

        }
    }
}
