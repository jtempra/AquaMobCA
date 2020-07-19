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

            if (context.Usuarios.Any())
            {
                return;
            }


            var Usuario = new UserEntity()
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
            };

            context.Usuarios.Add(Usuario);
            context.SaveChanges();

        }
    }
}
