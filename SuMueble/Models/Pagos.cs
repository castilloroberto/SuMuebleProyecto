using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Pagos")]
    public class Pagos:PagoControlador
    {
        public string IDColaborador { get; set; }

        [ExplicitKey]
        public Guid IDVenta { get; set; }

        public float Monto { get; set; }

        [Write(false)]
        [Computed]
        public DateTime Fecha { get; set; }
    }
}
