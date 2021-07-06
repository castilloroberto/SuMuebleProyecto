using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class DetalleVentaController : DBConnection
    {
        public bool InsertDetallesVenta(List<DetallesVentas> detallesVenta)
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
