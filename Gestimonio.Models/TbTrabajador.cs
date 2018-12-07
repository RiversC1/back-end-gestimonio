using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbTrabajador
    {
        public int CodigoTrabajador { get; set; }
        public int? CodigoTipoDocumento { get; set; }
        public string Dni { get; set; }
        public string NombreTrabajador { get; set; }
        public string ApellidoTrabajador { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int? CodigoCargo { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? CodigoEstado { get; set; }
    }
}
