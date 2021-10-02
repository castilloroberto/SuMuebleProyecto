using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Pagos")]
    public class Pago
    {
        public string IDColaborador { get; set; }

        [ForeignKey("")]
        public Guid IDVenta { get; set; }

        public float Monto { get; set; }

        public DateTime Fecha { get; set; }
    }
}
