using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Ventas")]
    public class Ventas
    {
        [ExplicitKey]
        public Guid ID { get; set; }

        [Write(false)]
        [Computed]
        public int CodigoFactura { get; set; }
        public string IDCliente { 
            get { return this.Cliente.DNI; }
            set { IDCliente = value; } 
        }
        public string IDColaborador { get; set; }

        [Write(false)]
        [Computed]
        public string NombreCliente { get; set; }

        [Write(false)]
        [Computed]
        public string Colaborador { get; set; }

        // Tipo de venta :
        // 1 al contado
        // 2 al credito
        public int IDTipoVenta { get; set; }

        [Write(false)]
        [Computed]
        public string TipoVenta { get; set; }
        public float Prima { get; set; }
        public int Cuotas { get; set; }

        [Write(false)]
        [Computed]
        public DateTime FechaInicio { get; set; }

        [Write(false)]
        [Computed]
        public float TotalVenta { get; set; }

        [Computed]
        public DateTime FechaFin { get; set; }

        // propiedades con de la parte programable
        [Write(false)]
        [Computed]
        public List<DetallesVentas> DetallesVenta { get; set; }

        [Write(false)]
        [Computed]
        public Clientes Cliente { get; set; }


        [Write(false)]
        [Computed]
        public List<Referencias> Referencias { get; set; }


    }
}
