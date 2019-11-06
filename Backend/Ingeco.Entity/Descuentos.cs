using System;

namespace Ingeco.Entity
{
    public class Descuentos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float Tasa { get; set; }
        public float MontoDescontado { get; set; }
        public string Responsable { get; set; }
    }
}