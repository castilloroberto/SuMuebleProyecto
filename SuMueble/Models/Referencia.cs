using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
   [Table("Referencias")]
    public class Referencia
    {
        public int Id { get; set; }

        [ForeignKey("Venta")]
        public int CodigoFactura { get; set; }
        public Venta Venta { get; set; }

        [MinLength(15), MaxLength(50)]
        public string Nombre { get; set; }
        
        [MinLength(13), MaxLength(13)]
        public string ReferenciaDNI { get; set; }
        
        [MinLength(8), MaxLength(8)]
        public string Telefono { get; set; }

        [MinLength(15), MaxLength(255)]
        public string Direccion { get; set; }

        [MinLength(6), MaxLength(6)]
        public string ReciboENEE { get; set; }

    }
}
