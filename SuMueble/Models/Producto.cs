using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Productos")]
    public class Producto:ProductoControlador
    {
        [Key]
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }

        public int Existencias { get; set; }

        public decimal PrecioUnitario { get; set; }


        public decimal ISV { get; set; }

        public int CategoriaFk { get; set; }

        public int EstadoFk { get; set; }
        
        [Write(false)]
        public ProductoEstado Estado { get; set; }
        public bool Activo { get; set; }

        public Producto()
        {
          Activo = true;
            Estado = new ProductoEstado();
        }
        public override string ToString()
        {
            return NombreProducto; 
        }
    }
}
