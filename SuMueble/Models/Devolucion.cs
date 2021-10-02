using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Devoluciones")]
    public class Devolucion
    {
        //Lave Primaria
        [Key]
        public int IDDevolucion 
        {
            set;get;
        }
        public int CodigoFactura
        {
            set; get;
        }
        public int IDProducto{set; get;}
        public int Cantidad
        {
            set; get;
        }
        public string Motivo
        {
            set; get;
        }
        public string Observaciones
        {
            set; get;
        }

        [Write(false)]
        public DateTime Fecha
        {
            set; get;
        }

    }
}
