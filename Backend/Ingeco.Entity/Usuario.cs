using System;
using System.Collections.Generic;

namespace Ingeco.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}