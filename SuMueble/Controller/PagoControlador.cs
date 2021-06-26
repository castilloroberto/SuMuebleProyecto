using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class PagoControlador:DBConnection
    {
        public bool InsertPagos(Pagos pago)
        {
            using (var db = GetConnection)
            {
                return db.Insert(pago) > 0 ;
            }
        }

        public bool UpdatePagos(Pagos pago)
        {
            using (var db = GetConnection)
            {
                return db.Update(pago);
            }
        }
    }
}
