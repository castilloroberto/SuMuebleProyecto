using Dapper.Contrib.Extensions;
using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Categorias")]
    public class Categorias:CategoriaController
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
    }
}
