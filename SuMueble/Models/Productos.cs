using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }

        public int Existencias { get; set; }

        public float PrecioUnitario { get; set; }

        public int ExistenciasUsado { get; set; }

        public float PrecioUnitarioUsado { get; set; }

        public float ISV { get; set; }

        public int IDCategoria { get; set; }

        public bool Estado { get; set; }

        public Productos()
        {
          Estado = true;
        }
    }
}
