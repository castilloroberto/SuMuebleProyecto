using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
   [Table("Referencias")]
    public class Referencia
    {
       [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string DNIReferencia { get; set; }
        public string Tel { get; set; }
        public string Direccion { get; set; }
        public string CodigoRecibo { get; set; }

        [Computed]
        public Guid IDVenta { get; set; }
    }
}
