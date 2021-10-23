using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }
        
        [Required]
        public decimal Precio { get; set; }
        
        [Required]
        public int Cantidad { get; set; }
        public decimal Impuesto { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString() => Nombre;


       
    }
}
