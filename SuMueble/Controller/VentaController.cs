using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class VentaController : DBConnection
    {
        DetalleVentaController detalleVentaController = new DetalleVentaController();
        ClienteControlador clienteControlador = new ClienteControlador();
        private bool InsertVenta(Ventas v)
        {
            using (var db = GetConnection)
            {
                return db.Insert<Ventas>(v) > 0;
            }
        }

        public bool SaveVenta(Ventas v)
        {
            bool ok = false;
            ok = clienteControlador.SaveCliente(v.Cliente);
            if(ok)
                ok = InsertVenta(v);
                    if (ok)
                        ok = detalleVentaController.InsertDetallesVenta(v.DetallesVenta);

            return ok;
        } 
    }
}
