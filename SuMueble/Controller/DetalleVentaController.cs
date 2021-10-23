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

        public DataTable GetDetalleVenta(int cod_factura)
        {
            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("Select * from v_venta1 where CodigoFactura = @cod_factura", db);
                command.Parameters.AddWithValue("@cod_factura", cod_factura);
                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado;


            }
        }

        public List<SQLViewVentas> GetDetalles(Guid IDVenta)
        {
            using (var db = GetConnection)
            {

                string sql = @"sp_SQLViewVentas @IDVenta";
                return db.Query<SQLViewVentas>(sql, new { IDVenta = IDVenta }).ToList();
            }
        }

        public List<DetallesVentas> ObtenerDetalles()
        {
            using (var db = GetConnection)
            {
                return db.GetAll<DetallesVentas>().ToList();
            }
        }
    }
}
