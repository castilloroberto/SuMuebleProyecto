using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Devoluciones")]
    public class Devoluciones
    {
        //Lave Primaria
        [ExplicitKey]
  
        public Guid ID 
        {
            set;get;
        }
        public Guid IDVenta
        {
            set; get;
        }
        public DateTime Fecha
        {
            set; get;
        }
        //Propiedades que no estan en la tabla
        public List<DetalleDevolucion> DetallesDevolucion
        {
            set; get;
        }
    }
}
