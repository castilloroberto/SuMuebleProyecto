using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public List<Devoluciones> ObtenerDevoluciones()
        {
            using (var db = GetConnection)
            {
                return db.GetAll<Devoluciones>().ToList();

            }

        }

        public Devoluciones ObtenerDevoluciones(int ID)
        {
            using (var db = GetConnection)
            {
                return db.Get<Devoluciones>(ID);

            }

        }


    }
}
