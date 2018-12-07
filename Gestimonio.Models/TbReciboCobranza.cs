using System;
using System.Collections.Generic;

namespace Gestimonio.Models
{
    public partial class TbReciboCobranza
    {
        public int IdDepartamento { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaVencimiento { get; set; }
    }
}
