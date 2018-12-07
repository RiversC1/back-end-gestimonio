using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbReserva
    {
        public string IdReserva { get; set; }
        public int? CodigoUsuario { get; set; }
        public string CodigoAreaComun { get; set; }
        public DateTime? FechaReserva { get; set; }
        public int? CantidaHoraMax { get; set; }
        public string EstadoReserva { get; set; }
        public int? CodigoVisitante { get; set; }
    }
}
