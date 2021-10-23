using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class CategoriaController : DBConnection
    {

        public IEnumerable<Categorias> GetCategorias()
        {
            using (var db = GetConnection)
            {
                return db.Query<Categorias>("select * from Categorias");
            }
        }

        public bool InsertCategorias(string categoria )
        {
            using (var db = GetConnection)
            {

                return db.Execute("Insert into categorias values(@categoria)", new { Categoria = categoria }) > 0;
            }
        }

    }
}
