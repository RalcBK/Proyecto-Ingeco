using System;

namespace Ingeco.Entity
{
    public class Facturas
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public int Correlativo { get; set; }
        public DateTime FechaVenta { get; set; }
        public float MontoTotal { get; set; }
        public DateTime FechaPago { get; set; }
        public int MonedaId { get; set; }
        public Moneda Moneda { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
    }
}