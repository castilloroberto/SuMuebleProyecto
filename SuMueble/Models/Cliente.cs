using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Clientes")]
    public class Cliente
    {


        [Key]
        [MinLength(13), MaxLength(13)]
        public string DNI { get; set; }

        [MinLength(14), MaxLength(14)]
        public string RTN { get; set; }

        [MinLength(3), MaxLength(100)]
        public string Nombre { get; set; }

        [MinLength(25), MaxLength(200)]
        public string Direccion { get; set; }

        [MinLength(8), MaxLength(8)]
        public string Telefono { get; set; }
        public List<Venta> Ventas { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Cliente()
        {
            FechaRegistro = DateTime.Now;
            Ventas = new List<Venta>();
        }

        public override string ToString() => Nombre;



    }
}
