using System;
using Ingeco.Entity;

namespace Ingeco.Repository.dto
{
    public class FacturaDto
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
        public string NombreCliente { get; set; }
    }
}