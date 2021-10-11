using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int CodigoFactura { get; set; }

        [ForeignKey("Colaborador")]
        public string ColaboradorDNI { get; set; }
        public Colaborador Colaborador { get; set; }

        [ForeignKey("Cliente")]
        public string ClienteDNI { get; set; }
        public Cliente Cliente { get; set; }

        public List<DetalleVenta> DetallesVenta { get; set; }
        public int TipoVentaId { get; set; }
        public TipoVenta TipoVenta { get; set; }
        public decimal Prima { get; set; }
        public int Cuotas { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public override string ToString() => $"{TipoVenta}";
        public Venta()
        {
            Fecha = DateTime.Now;
            FechaVencimiento = DateTime.Now;
            DetallesVenta = new List<DetalleVenta>();
        }



    }
}
