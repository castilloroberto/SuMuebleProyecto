using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Devoluciones")]
    public class Devolucion
    {
        //Lave Primaria
        public int Id { set; get; }

        [ForeignKey("Venta")]
        public int CodigoFactura { set; get; }
        public Venta Venta { set; get; }

        [ForeignKey("Producto")]
        public int ProductoId {set; get;}
        public Producto Producto {set; get;}
        public int Cantidad { set; get; }

        [MinLength(10), MaxLength(100)]
        public string Motivo { set; get; }

        [MinLength(10), MaxLength(255)]
        public string Observaciones { set; get; }

        public DateTime Fecha { set; get; }

        public Devolucion()
        {
            Fecha = DateTime.Now;
        }
    }
}
