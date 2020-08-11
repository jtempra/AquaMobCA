using Bogus;
using Domain.Entities;
using Domain.Enumerations;
using Infraestructure.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataSeed.Seeders
{
    public class UserSeeder
    {
        //public string NIF { get; set; }
        //public string Nombre { get; set; }
        //public string Apellidos { get; set; }
        //public string Direccion { get; set; }
        //public string Movil { get; set; }
        //public string Email { get; set; }
        //public string PathFoto { get; set; }
        //public TipoUsuario Rol { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string NombreCompleto => $"{Nombre} {Apellidos}";
        //public ICollection<LecturaEntity> Lecturas { get; set; }

        //public ICollection<IncidenciaEntity> Incidencias { get; set; }

        //public ICollection<OTEntity> OrdenesTrabajoCreadas { get; set; }

        //public ICollection<OTEntity> OrdenesTrabajoGestionadas { get; set; }

        private readonly AppDbContext _dbContext;

        public UserSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  void Seed()
        {
            if (!_dbContext.Usuarios.Any())
            {
                var UsersFake = new Faker<UserEntity>()
                    .RuleFor(u => u.Id, f => f.IndexFaker)
                    .RuleFor(u => u.NIF, f => f.Random.Number(8, 8).ToString())
                    .RuleFor(u => u.Nombre, f => f.Person.FirstName)
                    .RuleFor(u => u.Apellidos, f => f.Person.LastName)
                    .RuleFor(u => u.Direccion, f => (f.Address.StreetName() + "," + f.Address.BuildingNumber().ToString()))
                    .RuleFor(u => u.Movil, f => f.Phone.ToString())
                    .RuleFor(u => u.Email , (f,u) => f.Internet.Email(u.Nombre,u.Apellidos))
                    .RuleFor(u => u.PathFoto, f=> "c:\fotos\foto.jpg")
                    .RuleFor(u => u.Rol, f => f.PickRandom<TipoUsuario>())
                    .RuleFor(u => u.UserName, f => f.Person.UserName)
                    .RuleFor(u => u.Password, f => "123456")
                    .Generate(10);

                foreach (UserEntity user in UsersFake)
                {
                    _dbContext.Usuarios.Add(user);
                }

                _dbContext.SaveChangesAsync();

            }
        }
    }
}
