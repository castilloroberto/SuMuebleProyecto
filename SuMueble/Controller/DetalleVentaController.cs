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

        public IEnumerable<dynamic> GetDetalleVenta(Guid IDVenta)
        {
            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("Select * from DetallesVentas where IDVenta = @IDVenta", db);
                command.Parameters.AddWithValue("@IDVenta", IDVenta);
                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado.AsEnumerable();


            }
        }



    }
}
