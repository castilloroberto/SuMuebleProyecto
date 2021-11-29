using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Clientes")]
    public class Clientes:ClienteControlador
    {

        [Key]
        public int IdCliente { get; set; }
      
        public string DNI { get; set; }
        public string RTN { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        [Write(false)]
        public List<Ventas> Compras { get; set; }




        private float _montoInvertido;
        
        [Write(false)] // no se inserte en la base de datos
        public float MontoInvertido 
        { 
            get 
            {
                float total = 0;
                foreach (var item in Compras)
                {
                    total += item.TotalVenta;
                }
                return total;
            } 
            set 
            {
                _montoInvertido = value;
            }
        }


        [Write(false)] // insert no se inserta este atributo
        [Computed] // update no se actualiza este atributo
        public DateTime Registrado  { get; set; }

        public Clientes()
        {
            Compras = new List<Ventas>();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
