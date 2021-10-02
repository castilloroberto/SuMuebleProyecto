using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("DetallesVenta")]
    public class DetalleVenta
    {

        public int Id { get; set; }

        [ForeignKey("Venta")]
        public int VentaCodigoFactura { get; set; }
        public Venta Venta { get; set; }

        [ForeignKey("Producto")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }

        public override string ToString()
        {
            return $"{Cantidad}*{Producto.Nombre}: {Cantidad * PrecioVenta}";
        }



    }
}
