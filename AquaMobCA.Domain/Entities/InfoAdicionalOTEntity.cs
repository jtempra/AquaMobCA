namespace Domain.Entities
{
    public class InfoAdicionalOTEntity : BaseEntity
    {
        public string Clave { get; set; }

        public string Valor { get; set; }

        public OTEntity OrdenTrabajo { get; set; }
    }
}
