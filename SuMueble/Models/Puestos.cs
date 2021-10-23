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
        public int ID { get; set; }
        public string Puesto { get; set; }
    }
}
