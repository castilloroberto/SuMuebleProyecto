using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Impuesto { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString() => Nombre;


       
    }
}
