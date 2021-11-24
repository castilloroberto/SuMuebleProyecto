using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
   [Table("Referencias")]
    public class Referencias:ReferenciaController
    {
       [Key]
        public int IdReferencia { get; set; }
        public string Nombre { get; set; }
        public string DNIReferencia { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CodigoRecibo { get; set; }

        public int VentaFk { get; set; }
        public Ventas Venta { get; set; }
    }
}
