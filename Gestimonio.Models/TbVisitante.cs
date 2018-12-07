using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbVisitante
    {
        public int CodigoVisitante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? CodigoTipoDocumento { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
    }
}
