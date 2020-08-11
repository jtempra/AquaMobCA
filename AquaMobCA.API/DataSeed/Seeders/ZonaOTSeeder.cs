using Bogus;
using Domain.Entities;
using Infraestructure.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataSeed.Seeders
{
    public class ZonaOTSeeder
    {
        //public string Codigo { get; set; }

        //public string Zona { get; set; }

        //public PoblacionOTEntity Poblacion { get; set; }

        //public ICollection<OTEntity> OrdenesTrabajo { get; set; }

        private readonly AppDbContext _dbContext;

        public ZonaOTSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (!_dbContext.ZonasOT.Any())
            {
                var ZonasOTFake = new Faker<ZonaOTEntity>()
                    .RuleFor(a => a.Id, f => f.IndexFaker)
                    .RuleFor(a => a.Codigo, f => f.Random.String(5, 5).ToString())
                    .RuleFor(a => a.Zona, f => f.Lorem.Sentences(1));
            }
        }
    }
}
