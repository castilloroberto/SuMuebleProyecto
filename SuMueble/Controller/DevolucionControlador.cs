using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class DevolucionControlador: DBConnection
    {
       
        public bool InsertarDevolucion(Devoluciones d)
        {
            using (var db=GetConnection)
            {
                long s = 0;
                s = db.Insert<Devoluciones>(d);
                if (s > 0)
                    return true;
                else
                    return false;

            }

        }
        

    }
}
