using Domain.Entities;
using Infraestructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AnotacionOTEntity> AnotacionesOT { get; set; }
        public DbSet<CalleOTEntity> Calles { get; set; }
        public DbSet<ConceptoOTEntity> ConceptosOT { get; set; }
        public DbSet<DetalleOTEntity> DetallesOT { get; set; }
        public DbSet<EquipoOTEntity> EquiposOT { get; set; }
        public DbSet<FotoEntity> Fotos { get; set; }
        public DbSet<HistoricoLecturasEntity> HistoricosLecturas { get; set; }
        public DbSet<IncidenciaEntity> Incidencias { get; set; }
        public DbSet<InfoAdicionalOTEntity> InfosAdicionalesOT { get; set; }
        public DbSet<InstalacionOTEntity> InstalacionesOT { get; set; }
        public DbSet<LecturaEntity> Lecturas { get; set; }
        public DbSet<OTEntity> OrdenesTrabajo { get; set; }
        public DbSet<PoblacionOTEntity> Poblaciones { get; set; }
        public DbSet<RutaLecturaEntity> RutasLectura { get; set; }
        public DbSet<SubinstalacionOTEntity> SubinstalacionesOT { get; set; }
        public DbSet<TipoIncidenciaLecturaEntity> TiposIncidenciaLecturas { get; set; }
        public DbSet<TipoIncidenciaEntity> TiposIncidencia { get; set; }
        public DbSet<TipoOTEntity> TiposOT { get; set; }
        public DbSet<TipoOrigenIncidenciaEntity> TiposOrigenesIncidencias { get; set; }
        public DbSet<UserEntity> Usuarios { get; set; }
        public DbSet<ZonaOTEntity> ZonasOT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnotacionOTConfiguration());
            modelBuilder.ApplyConfiguration(new CalleOTConfiguration());
            modelBuilder.ApplyConfiguration(new ConceptoOTConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleOTConfiguration());
            modelBuilder.ApplyConfiguration(new EquipoOTConfiguration());
            modelBuilder.ApplyConfiguration(new FotoConfiguration());
            modelBuilder.ApplyConfiguration(new HistoricoLecturasConfiguration());
            modelBuilder.ApplyConfiguration(new IncidenciaConfiguration());
            modelBuilder.ApplyConfiguration(new InfoAdicionalConfiguration());
            modelBuilder.ApplyConfiguration(new InstalacionOTConfiguration());
            modelBuilder.ApplyConfiguration(new LecturaConfiguration());
            modelBuilder.ApplyConfiguration(new OTConfiguration());
            modelBuilder.ApplyConfiguration(new PoblacionOTConfiguration());
            modelBuilder.ApplyConfiguration(new RutaLecturaConfiguration());
            modelBuilder.ApplyConfiguration(new SubinstalacionOTConfiguration());
            modelBuilder.ApplyConfiguration(new TipoIncidenciaLecturaConfiguration());
            modelBuilder.ApplyConfiguration(new TipoIncidenciaConfiguration());
            modelBuilder.ApplyConfiguration(new TipoOTConfiguration());
            modelBuilder.ApplyConfiguration(new TipoOrigenIncidenciaConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ZonaOTConfiguration());

            // apliquem de cop totes les configuracions de les entitats

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnotacionOTConfiguration).Assembly);


        }
    }
}
