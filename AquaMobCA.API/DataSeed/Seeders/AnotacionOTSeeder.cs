using Bogus;
using Domain.Entities;
using Infraestructure.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataSeed.Seeders
{
    public class AnotacionOTSeeder
    {
        //public string Anotacion { get; set; }
        //public DateTime Fecha { get; set; }
        //public DateTime FechaLocal => Fecha.ToLocalTime();
        //public UserEntity Operario { get; set; }
        //public OTEntity OrdenTrabajo { get; set; }

        private readonly AppDbContext _dbContext;

        public AnotacionOTSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       public void Seed()
        {
            if (!_dbContext.AnotacionesOT.Any())
            {
                var AnotacionesOTFake = new Faker<AnotacionOTEntity>()
                    .RuleFor(a => a.Id, f => f.IndexFaker)
                    .RuleFor(a => a.Anotacion, f => f.Lorem.Sentences(1))
                    .RuleFor(a => a.Fecha, f => f.Date.Past())
                    .Generate(100);
                    
            }
        }

    }
}
