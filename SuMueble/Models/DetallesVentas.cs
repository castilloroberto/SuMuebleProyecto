using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("DetallesVentas")]
    public class DetallesVentas
    {

        [ExplicitKey]
        public Guid IDVenta { get; set; }
        public int IDProducto { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int cantidadDevuelta { get; set; }
        public float descuento { get; set; }


        // propiedades que no forman parte de la tabla 
        [Write(false)]
        [Computed]
        public float SubTotal 
        {
            get { return PrecioVenta * Cantidad; } 
             
        }

        [Write(false)]
        [Computed]
        public string Producto { get; set; }

        [Write(false)]
        [Computed]
        public float PrecioProducto { get; set; }

        [Write(false)]
        [Computed]
        public string Info 
        {
            get { return $"*{Cantidad} *{Producto}  *Subtotal: {SubTotal}"; }
        }


    }
}
