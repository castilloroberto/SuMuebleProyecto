using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using SuMueble.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Colaboradores")]
    public class Colaborador:ColaboradorControlador 
    {
        [Key]
        public int IdColaborador { get; set; }

        public string DNI { get; set; }
        public string RTN { get; set; }


        public string Nombre { get; set; }

        public string Clave { get; set; }


        [Write(false)]
        public Puestos Puesto { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaContratado { get; set; }

        public Nullable<DateTime> FechaFinContrato { get; set; }

        public bool Activo { get; set; }
        public int PuestoFk { get; set; }

        public Colaborador()
        {
            Activo = true;
            FechaNacimiento = DateTime.Now.AddYears(-18);
            FechaContratado = DateTime.Now;
            FechaFinContrato = DateTime.Now.AddYears(10);
        }

        public override string ToString()
        {
            return Nombre;

        }

    }
}
