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
        [Key]
        public int IdDevolucion { set; get; }
        public int VentaFk { set; get; }
        public int ColaboradorFk { set; get; }
        
        [Write(false)]
        public List<DetalleDevolucion> DetalleDevolucion { get; set; }

        [Write(false)]
        public DateTime Fecha { set; get; }

    }
}
