using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    public class SQLViewVentas
    {

        public Guid IDVenta { get; set; }
        public int CodigoFactura { get; set; }
        public float Prima { get; set; }
        public int Cuotas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IDTipoVenta { get; set; }
        public string TipoVenta { get; set; }
        public string IDCliente { get; set; }
        public string Cliente { get; set; }
        public string IDColaborador { get; set; }
        public string Colaborador { get; set; }
        public int IDProducto { get; set; }
        public string Producto { get; set; }
        public int IDCategoria { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public float PrecioVenta { get; set; }
        public int CantidadDevuelta { get; set; }



    }
}
