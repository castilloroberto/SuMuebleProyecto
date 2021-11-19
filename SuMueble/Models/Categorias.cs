using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
    }
}
