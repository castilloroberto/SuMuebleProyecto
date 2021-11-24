using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuMueble.Controller
{
    public class ProductoControlador : BasicController<Producto>
    {

        public List<Producto> IncludeEstado()
        {
            using (var db = GetConnection)
            {
                string sql = "select * from productos";
               var prods = db.Query<Producto>(sql).ToList();
                var res = prods.ConvertAll(p => 
                {
                    p.Estado = p.Estado.Get(p.EstadoFk);
                    return p;
                });
                return res;
            }
        }
        public bool Save(Producto producto)
        {
           if (producto.IdProducto == 0)
            {
                
               return Insert(producto) > 0;
            }
            else
            {
               return Update(producto);
            }
        }

        
    }
}
