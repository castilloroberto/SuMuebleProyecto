using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
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

        internal DataRow GetVenta()
        {
            throw new NotImplementedException();
        }

        public Guid GetVentaDapper(int CodigoFactura)
        {
            using (var db = GetConnection)
            {
                string sql = "SELECT ID FROM Ventas WHERE CodigoFactura = @CodigoFactura";
                return db.QuerySingle<Guid>(sql, new { CodigoFactura }); 
            }
        }

        public Ventas GetVentaByGuid(Guid guid)
        {
            using (var db = GetConnection)
            {
                return db.Get<Ventas>(guid);
            }
        }

        public bool SaveVenta(Ventas v)
        {
            bool ok = clienteControlador.SaveCliente(v.Cliente);

            if (ok == true)
            {
                if (InsertVenta(v))
                {
                    if(v.Referencias != null)
                        ok = rController.InsertReferencia(v.Referencias);    
                        
                    ok = detalleVentaController.InsertDetallesVenta(v.DetallesVenta);

                }

            }
            
            return ok;
        }

        public IEnumerable<Ventas> ObtenerVenta()
        {
            string sql = @"select * from Ventas order by CodigoFactura";
            using (var db = GetConnection)
            {       
                return db.Query<Ventas>(sql);
            }       
        }

        public Ventas GetVentaID(string cod_factura)
        {
            string sql = @$"select * from v_ventasResumen where CodigoFactura = {cod_factura} order by CodigoFactura";
            using (var db = GetConnection)
            {
                return db.QueryFirst<Ventas>(sql);
            }
        }

        public DataRow GetVenta(string cod_factura)
        {
            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("Select * from Ventas where CodigoFactura = @CodigoFactura", db);
                command.Parameters.AddWithValue("@CodigoFactura", cod_factura);
                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();

                resultado.Load(reader);

                reader.Close();

                return resultado.AsEnumerable().First();


            }
        }

        public DataTable GetCreditosPendientes()
        {
            using (var db = GetConnection)
            {
                db.Open();
                SqlCommand command = new SqlCommand("Select * from ventas where IDTipoVenta = 2 order by CodigoFactura", db);
                SqlDataReader reader = command.ExecuteReader();
                DataTable resultado = new DataTable();
               
                resultado.Load(reader);

                reader.Close();

                return resultado; 


            }
        }
    }
}
