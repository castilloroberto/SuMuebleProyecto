using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class PuestoControlador:DBConnection 
    {
        public IEnumerable<Puestos> GetPuestos()
        {
            using (var DB = GetConnection)
            {
              return DB.GetAll<Puestos>();
            }
        }
        public bool InsertarPuestos(string Puesto)
        {
            using (var DB = GetConnection)
            {
                return DB.Insert<Puestos>(new Puestos{ID=0,Puesto=Puesto})>0;
            }
        }
    }
}
