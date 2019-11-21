namespace Ingeco.Entity
{
    public class CostoGasto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Monto { get; set; }
        public bool Inicio { get; set; }
        public int DescuentoId { get; set; }
        public Descuento Descuento { get; set; }
    }
}