using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
        public override string ToString() => Nombre;

        public Categoria()
        {
            Productos = new List<Producto>();
        }

    }
}
