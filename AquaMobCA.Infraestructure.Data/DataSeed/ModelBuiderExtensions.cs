using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence.DataSeed
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // usuaris

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = 1,
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
                },
                new UserEntity
                {
                    Id = 2,
                    NIF = "55667788B",
                    Nombre = "Joan",
                    Apellidos = "Toful Castanyer",
                    Direccion = "Carrer Via Apia, 102-1-4",
                    Movil = "600112233",
                    Email = "jtc@terra.es",
                    PathFoto = "c:\\fotos\\jtc.jpg",
                    Rol = TipoUsuario.Operario,
                    UserName = "toful",
                    Password = "123456",
                    Lecturas = new List<LecturaEntity>(),
                    Incidencias = new List<IncidenciaEntity>(),
                    OrdenesTrabajoCreadas = new List<OTEntity>(),
                    OrdenesTrabajoGestionadas = new List<OTEntity>()
                },
                new UserEntity
                {
                    Id = 3,
                    NIF = "00998877X",
                    Nombre = "Jordi",
                    Apellidos = "Font Cagarro",
                    Direccion = "Carrer del Montgros, 5",
                    Movil = "615051814",
                    Email = "jfg@terra.es",
                    PathFoto = "c:\\fotos\\jfg.jpg",
                    Rol = TipoUsuario.Encargado,
                    UserName = "jfont",
                    Password = "123456",
                    Lecturas = new List<LecturaEntity>(),
                    Incidencias = new List<IncidenciaEntity>(),
                    OrdenesTrabajoCreadas = new List<OTEntity>(),
                    OrdenesTrabajoGestionadas = new List<OTEntity>()
                }
            );
        }
    }
}
