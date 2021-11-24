using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SuMueble.Controller
{
    public class DetalleVentaController : BasicController<DetallesVentas>
    {

        public bool Insert(List<DetallesVentas> detallesVenta)
        {
            using (var db = GetConnection)
            {
                bool ok = false;
                long rows =  db.Insert(detallesVenta) ;
                ok = rows >= detallesVenta.Count;
                return ok;
            }

        }

       

       

       
    }
}
