using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbUsuario
    {
        public int CodigoUsuario { get; set; }
        public int? CodigoCargo { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int? CodigoTipoDocumento { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? CodigoEstado { get; set; }
    }
}
