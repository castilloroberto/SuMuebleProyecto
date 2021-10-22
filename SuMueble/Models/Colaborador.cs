using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Colaboradores")]
    public class Colaborador 
    {
        [Key]
        [MinLength(13), MaxLength(13)]
        public string DNI { get; set; }

        [MinLength(14), MaxLength(14)]
        public string RTN { get; set; }

        [MinLength(15), MaxLength(100)]
        public string Nombre { get; set; }

        [MinLength(25), MaxLength(200)]
        public string Direccion { get; set; }



        [MinLength(18), MaxLength(320)]
        public string Email { get; set; }


        [MinLength(8), MaxLength(8)]
        public string Telefono { get; set; }

        [MinLength(8), MaxLength(255)]
        public string Clave { get; set; }

        public int PuestoId { get; set; }
        public Puesto Puesto { get; set; }


        public List<Venta> Ventas { get; set; }
        public List<Pago> Pagos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratado { get; set; }
        public DateTime FechaFinContrato { get; set; }
        public bool Activo { get; set; }

        public Colaborador()
        {
            FechaContratado = DateTime.Now;
            FechaNacimiento = new DateTime(DateTime.Now.Year-18, 8, 31);
            FechaFinContrato = DateTime.Now.AddYears(5);
            Activo = true;
            Ventas = new List<Venta>();
            Pagos = new List<Pago>();
        }

        public override string ToString() => Nombre;




    }
}
