using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbAreaComun
    {
        public int CodigoAreaComun { get; set; }
        public string NombreAreaComun { get; set; }
        public string DescripcionAreaComun { get; set; }
        public int? LimiteReserva { get; set; }
        public int? CodigoSemana { get; set; }
        public int? CodigoEstado { get; set; }
        public int? HoraMaxima { get; set; }
    }
}
