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
                return db.Insert(detallesVenta) == detallesVenta.Count;
            }
        }
    }
}
