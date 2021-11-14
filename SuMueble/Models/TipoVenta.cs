using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("TiposVentas")]
    public class TipoVenta
    {
        [Key]
        public int ID { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
