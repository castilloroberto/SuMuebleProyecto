using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SuMueble.Controller
{
    public class VentaController : DBConnection
    {
        ReferenciaController rController = new ReferenciaController();

        public List<Ventas> IncludeAll()
        {
            using (var db = GetConnection)
            {
                List<Ventas> ventas = new List<Ventas>();
              
                ventas = db.GetAll<Ventas>().ToList();

                var list = ventas.ConvertAll(venta =>
                {
                    venta.Cliente = db.Get<Clientes>(venta.IDCliente);
                    venta.Colaborador = db.Get<Colaborador>(venta.IDColaborador);
                    venta.TipoVenta = db.Get<TipoVenta>(venta.IDTipoVenta);
                    venta.DetallesVenta = db.Query<DetallesVentas>("select * from DetallesVentas where idventa = @id", new { id = venta.ID }).ToList();
                    return venta;
                });
                return list;
            }
        }
        public List<Ventas> IncludeDetalles(string clienteId = "" )
        {
            using (var db = GetConnection)
            {
                List<Ventas> ventas = new List<Ventas>(); 
                if (clienteId != "")
                {
                    string sql = @"
                            select * from ventas where idcliente = @id
                        ";
                    ventas = db.Query<Ventas>(sql, new { id = clienteId }).ToList();

                } 
                else
                {

                    ventas = db.GetAll<Ventas>().ToList();
                } 

                var list = ventas.ConvertAll(venta => 
                {
                    venta.DetallesVenta = db.Query<DetallesVentas>("select * from DetallesVentas where idventa = @id", new { id = venta.ID }).ToList();
                    return venta;
                });
                return list;
            }

        }

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
            var clienteControlador = new ClienteControlador();

            var detalleVentaController = new DetalleVentaController();

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
