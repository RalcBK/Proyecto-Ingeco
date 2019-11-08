using System;
using System.Collections.Generic;

namespace Ingeco.Entity
{
    public class Descuento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float Tasa { get; set; }
        public float MontoDescontado { get; set; }
        public float TEA { get; set; }
        public float TCEA { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
        public IEnumerable<CostoGasto> CostosGastos { get; set; }
    }
}