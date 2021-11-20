using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;

namespace SuMueble.Controller
{
    public class DevolucionControlador: DBConnection
    {
       
        public dynamic InsertarDevolucion(Devoluciones d)
        {
            using (var db = GetConnection)
            {
      
                return db.Insert(new[] { d });

            }

        }

        public List<Devoluciones> GetAll()
        {
            using (var db = GetConnection)
            {
                string sql = "seelct * from DetalleDevolucion where DevolucioneFk = @id";
                var devoluciones = db.GetAll<Devoluciones>().ToList();
                var res = devoluciones.ConvertAll(d => {
                    d.DetalleDevolucion = db.Query<DetalleDevolucion>(sql,new { id=d.IdDevolucion}).ToList();
                    return d;
                });
                return res;
            }

        }

        public Devoluciones Get(int id)
        {
            using (var db = GetConnection)
            {
                return db.Get<Devoluciones>(id);

            }

        }


    }
}
