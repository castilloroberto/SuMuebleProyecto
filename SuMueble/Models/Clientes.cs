using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        internal object cliente;

        // espesificar que es una llave creada en el programa
        [ExplicitKey]
        public string DNI { get; set; }
        public string RTN { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }


        
        [Write(false)] // insert no se inserta este atributo
        [Computed] // update no se actualiza este atributo
        public DateTime Registrado  { get; set; }

        internal static object Where<T>(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
