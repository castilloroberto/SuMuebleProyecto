using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("DetallesVentas")]
    public class DetallesVentas
    {

        [Key]
        public int VentaFk { get; set; }
        public int ProductoFk { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public float Descuento { get; set; }


        private float _subTotal;
        // propiedades que no forman parte de la tabla 
        [Write(false)]
        public float SubTotal 
        {
            get { return (PrecioVenta * Cantidad) - Descuento; }
            set 
            {
                _subTotal = value;
            }
        }

        
        [Write(false)]
        public Productos Producto { get; set; }

       

        [Write(false)]
        public string Info 
        {
            get { return $"*{Cantidad} *{Producto}  *Subtotal: {SubTotal}"; }
        }


    }
}
