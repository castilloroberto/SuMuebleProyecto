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
    public class PagoControlador : DBConnection
    {
        public bool InsertPagos(Pagos pago)
        {
            using (var db = GetConnection)
            {
                return db.Insert<Pagos>(pago) > 0;
            }
        }

        public bool UpdatePagos(Pagos pago)
        {
            using (var db = GetConnection)
            {
                return db.Update<Pagos>(pago);
            }
        }


        public IEnumerable<dynamic> GetPagos( Guid IDVenta)
        {

            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("Select * from v_VentasCredito", db);
                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado.AsEnumerable();
                
            }




        }

    }
}
