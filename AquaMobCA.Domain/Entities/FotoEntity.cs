namespace Domain.Entities
{
    public class FotoEntity : BaseEntity
    {
        public string RutaFoto { get; set; }

        public LecturaEntity Lectura { get; set; }
        public OTEntity OdenTrabajo { get; set; }
        public IncidenciaEntity Incidencia { get; set; }
    }
}
