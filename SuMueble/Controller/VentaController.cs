using Dapper;
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
        ReferenciaController rController = new ReferenciaController();
        private bool InsertVenta(Ventas v)
        {
            using (var db = GetConnection)
            {
                return db.Insert(v) > 0;
            }
        }

        public bool SaveVenta(Ventas v)
        {
            bool ok = false;
            if(clienteControlador.SaveCliente(v.Cliente))
                if (InsertVenta(v))
                    if(v.Referencias.Count>0)
                        ok = rController.InsertReferencia(v.Referencias);    
                        
                    ok = detalleVentaController.InsertDetallesVenta(v.DetallesVenta);
            
            return ok;
        }

        public IEnumerable<Ventas> ObtenerVenta()
        {
            string sql = @"select * from v_ventasResumen order by CodigoFactura";
            using (var db = GetConnection)
            {
                return db.Query<Ventas>(sql);
            }
        }
    }
}
