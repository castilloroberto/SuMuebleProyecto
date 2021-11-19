using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Puestos")]
    public class Puestos
    {
        [Key]
        public int IdPuesto { get; set; }
        public string Puesto { get; set; }

        public override string ToString()
        {
            return Puesto;
        }
    }
}
