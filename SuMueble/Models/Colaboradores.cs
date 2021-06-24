using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Colaboradores")]
    public class Colaboradores 
    { 
        [ExplicitKey]
        public string DNI { get; set; }

        public string RTN { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }

        public int IDPuesto { get; set; }

        public string Direccion { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime Contratado { get; set; }

        public DateTime FinContrato { get; set; }

        public Boolean Estado { get; set; }



    }
}
