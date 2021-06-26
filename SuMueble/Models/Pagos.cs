using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Pagos")]
    public class Pagos
    {
        public string IDColaborador { get; set; }
        [ExplicitKey]
        public Guid IDVenta { get; set; }

        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
