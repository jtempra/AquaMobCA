using Bogus;
using Domain.Entities;
using Domain.Enumerations;
using Infraestructure.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace API.DataSeed
{
    public class DbSeed
    {
        private readonly AppDbContext _dbContext;

        public DbSeed(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<AnotacionOTEntity> SeedAnotacionOT(int numSeeds)
        {
            var AnotacionesOTFake = new Faker<AnotacionOTEntity>()
                    .RuleFor(a => a.Id, f => f.IndexFaker)
                    .RuleFor(a => a.Anotacion, f => f.Lorem.Sentences(1))
                    .RuleFor(a => a.Fecha, f => f.Date.Past())
                    .Generate(numSeeds);

            return AnotacionesOTFake;
        }

        public CalleOTEntity SeedCalleOT()
        { 
            var CalleOTFake = new Faker<CalleOTEntity>()
                    .RuleFor(c => c.Id, f => f.IndexFaker)
                    .RuleFor(c => c.Codigo, f => f.Random.String(5,5))
                    .RuleFor(c => c.Calle, f => f.Address.StreetName())
                    .Generate();

            return CalleOTFake;
        }

        public List<ZonaOTEntity> SeedZonaOT(int numSeeds)
        {
            var ZonasOTFake = new Faker<ZonaOTEntity>()
                        .RuleFor(a => a.Id, f => f.IndexFaker)
                        .RuleFor(a => a.Codigo, f => f.Random.String(5, 5))
                        .RuleFor(a => a.Zona, f => f.Random.String(5, 15))
                        .Generate(numSeeds);

            return ZonasOTFake;
        }

        public PoblacionOTEntity SeedPoblacionOT()
        {
            var PoblacionOTFake = new Faker<PoblacionOTEntity>()
                        .RuleFor(p => p.Id, f => f.IndexFaker)
                        .RuleFor(p => p.Codigo, f => f.Random.String(5, 5))
                        .RuleFor(p => p.Poblacion, f => f.Address.City())
                        .RuleFor(p => p.Zonas, f=> SeedZonaOT(3))
                        .Generate();

            return PoblacionOTFake;
        }
        public ConceptoOTEntity SeedConceptoOT()
        {
            var ConceptoOTFake = new Faker<ConceptoOTEntity>()
                        .RuleFor(c => c.Id, f => f.IndexFaker)
                        .RuleFor(c => c.Codigo, f => f.Random.String(5, 5))
                        .RuleFor(c => c.Concepto, f => f.Random.String(5, 15))
                        .RuleFor(c => c.Tipo, f => f.PickRandom<TipoConceptoOT>())
                        .Generate();

            return ConceptoOTFake;
        }

        public List<EquipoOTEntity> SeedEquipoOTEntity(int numSeeds)
        {
            var EquiposOTFake = new Faker<EquipoOTEntity>()
                        .RuleFor(e => e.Id, f => f.IndexFaker)
                        .RuleFor(e => e.Equipo, f => f.Lorem.Sentence())
                        .RuleFor(e => e.Observaciones, f => f.Lorem.Sentence(3))
                        .Generate(numSeeds);

            return EquiposOTFake;
        }

        public List<SubinstalacionOTEntity> SeedSubinstalacionOTEntity(int numSeeds)
        {
            var SubinstacionesOTFake = new Faker<SubinstalacionOTEntity>()
                        .RuleFor(s => s.Id, f => f.IndexFaker)
                        .RuleFor(s => s.Subinstalacion, f => f.Lorem.Sentence())
                        .RuleFor(s => s.Observaciones, f => f.Lorem.Sentence(3))
                        .RuleFor(s => s.Equipos, f => SeedEquipoOTEntity(5))
                        .Generate(numSeeds);

            return SubinstacionesOTFake;
        }

        public InstalacionOTEntity SeedInstalacionOTEntity()
        {
            var InstalacionOTFake = new Faker<InstalacionOTEntity>()
                        .RuleFor(i => i.Id, f => f.IndexFaker)
                        .RuleFor(i => i.Instalacion, f => f.Lorem.Sentence())
                        .RuleFor(i => i.Observaciones, f => f.Lorem.Sentence(3))
                        .RuleFor(i => i.Poblacion, f => SeedPoblacionOT())
                        .RuleFor(i => i.Subinstalaciones, f => SeedSubinstalacionOTEntity(5))
                        .Generate();

            return InstalacionOTFake;
        }

        public List<FotoEntity> SeedFotoEntity(int numSeeds)
        {
            var FotosFake = new Faker<FotoEntity>()
                        .RuleFor(p => p.Id, f => f.IndexFaker)
                        .RuleFor(p => p.RutaFoto, f => "c:\\fotos\\" + f.Random.String(5,10))
                        .Generate(numSeeds);

            return FotosFake;
        }

        public TipoIncidenciaLecturaEntity SeedTipoIncidenciaLecturaEntity()
        {
            var TipoIncidenciaLecturaFake = new Faker<TipoIncidenciaLecturaEntity>()
                        .RuleFor(p => p.Id, f => f.IndexFaker)
                        .RuleFor(p => p.Codigo, f => f.Random.String(5,5))
                        .RuleFor(p => p.Incidencia, f => f.Lorem.Sentence(1))
                        .RuleFor(p => p.Observaciones, f => f.Lorem.Sentence(3))
                        .Generate();

            return TipoIncidenciaLecturaFake;
        }
        public List<HistoricoLecturasEntity> SeedHistoricoLecturasEntity(int numSeeds)
        {
            var HistoricoLecturasFake = new Faker<HistoricoLecturasEntity>()
                        .RuleFor(h => h.Id, f => f.IndexFaker)
                        .RuleFor(h => h.NumeroContrato, f => f.Random.Int())
                        .RuleFor(h => h.Periodo, f => 202000 + f.Random.Int(1, 12))
                        .RuleFor(h => h.Lectura, f => f.Random.Float())
                        .RuleFor(h => h.FechaLectura, f => f.Date.Past())
                        .RuleFor(h => h.ConsumoLectura, f => f.Random.Float())
                        .RuleFor(h => h.ConsumoImputado, f => f.Random.Float())
                        .RuleFor(h => h.ConsumoEstimado, f => f.Random.Float())
                        .RuleFor(h => h.ConsumoFacturado, f => f.Random.Float())
                        .RuleFor(h => h.IncidenciaLectura, f => SeedTipoIncidenciaLecturaEntity())
                        .Generate(numSeeds);

            return HistoricoLecturasFake;
        }
    }
}
