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

        public bool Insert(List<DetallesVentas> detallesVenta,int idVenta)
        {
            using (var db = GetConnection)
            {
                detallesVenta = detallesVenta.ConvertAll((dv) => 
                {
                    dv.VentaFk = idVenta;
                    return dv;
                });
                return db.Insert(detallesVenta) > 0;
                 
            }

        }

       

       

       
    }
}
