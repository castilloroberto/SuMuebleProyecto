using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Ventas")]
    public class Ventas:VentaController
    {
        [Key]
        public int IdVenta { get; set; }


        public int ClienteFK { get; set;}

        [Write(false)]
        public Clientes Cliente { get; set; }
       
        public int ColaboradorFk { get; set; }


        [Write(false)]
        public Colaborador Colaborador { get; set; }

        // Tipo de venta :
        // 1 al contado
        // 2 al credito
        public int TipoVentaFk { get; set; }

        [Write(false)]
        public TipoVenta TipoVenta { get; set; }
        public float Prima { get; set; }
        public int Cuotas { get; set; }

        [Write(false)]
        [Computed]
        public DateTime FechaVenta { get; set; }

        private float _totalVenta; 
        [Write(false)]
        [Computed]
        public float TotalVenta 
        { 
            get 
            {
                float total = 0;
                foreach (var item in DetallesVenta)
                {
                    total += item.SubTotal;
                }
                return total;
            } 
            set 
            {
                
                 
                _totalVenta = value;
            } 
        } 
        
        [Write(false)]
        [Computed]
        public float Descuento { get; set; }

        //[Computed]
        public DateTime FechaFinCredito { get; set; }

        // propiedades con de la parte programable
        [Write(false)]
        [Computed]
        public List<DetallesVentas> DetallesVenta { get; set; }

        


        [Write(false)]
        [Computed]
        public List<Referencias> Referencias { get; set; }
        public Ventas()
        {
            DetallesVenta = new List<DetallesVentas>(); 
        }

    }
}
