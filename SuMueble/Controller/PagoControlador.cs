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
    public class PagoControlador : DBConnection
    {
        public bool InsertPagos(Pagos pago)
        {
            
            using (var db = GetConnection)
            {
                return db.Insert(new[] { pago } ) > 0;
            }
        }

        public bool UpdatePagos(Pagos pago)
        {
            using (var db = GetConnection)
            {
                return db.Update<Pagos>(pago);
            }
        }

        public Nullable<float> GetPagado(Guid IDVenta)
        {
            using (var db = GetConnection )
            {
                string sql = "select sum(Monto) Pagado from pagos where IDVenta = @IDVenta";
                return db.QuerySingle<Nullable<float>>(sql, new {IDVenta});
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

        public  DataTable GetCuotasPendientes(int CodigoFactura)
        {
            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("getCuotasPendiente", db);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodigoFactura", CodigoFactura);

                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado;

            }
        }

        public DataTable GetCreditoPendiente(int CodigoFactura)
        {

            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("getCreditoPendiente", db);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodigoFactura", CodigoFactura);

                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado;

            }
        }

    }
}
