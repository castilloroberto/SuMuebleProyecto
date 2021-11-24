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
    public class PagoControlador : BasicController<Pagos>
    {
       

        

    


        public List<Pagos> GetByIdVenta( int idVenta)
        {

            using (var db = GetConnection)
            {
                string sql = "Select * from Pagos where IdVenta = @id";
                return db.Query<Pagos>(sql, new { id=idVenta}).ToList();
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
