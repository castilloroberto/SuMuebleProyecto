using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("ProductoEstado")]
    public class ProductoEstado:BasicController<ProductoEstado>
    {
        [Key]
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public override string ToString()
        {
            return Estado;
        }
    }
}
