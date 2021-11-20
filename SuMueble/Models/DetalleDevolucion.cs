using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("DetalleDevolucion")]
    public class DetalleDevolucion
    {
        public int DevolucionFk { set; get; }

        public int ProductoFk { set; get; }
        public int Cantidad { set; get; }
        public string Motivo { set; get; }
        public string Observaciones { set; get; }
    }
}
