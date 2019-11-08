using System;

namespace Ingeco.Entity
{
    public class Factura
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public DateTime FechaVenta { get; set; }
        public float Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
    }
}