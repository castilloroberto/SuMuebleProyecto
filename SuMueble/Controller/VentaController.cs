using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SuMueble.Controller
{
    public class VentaController : BasicController<Ventas>
    {
        Referencias Referencia = new Referencias();

        public List<Ventas> IncludeAll()
        {
            using (var db = GetConnection)
            {
                List<Ventas> ventas = new List<Ventas>();
              
                ventas = db.GetAll<Ventas>().ToList();

                var list = ventas.ConvertAll(venta =>
                {
                    venta.Cliente = db.Get<Clientes>(venta.ClienteFK);
                    venta.Colaborador = db.Get<Colaborador>(venta.ColaboradorFk);
                    venta.TipoVenta = db.Get<TipoVenta>(venta.TipoVentaFk);
                    venta.DetallesVenta = db.Query<DetallesVentas>("select * from DetallesVentas where ventafk = @id", new { id = venta.IdVenta }).ToList();
                    return venta;
                });
                return list;
            }
        }
        public List<Ventas> IncludeDetalles(int clienteId = 0 )
        {
            using (var db = GetConnection)
            {
                List<Ventas> ventas = new List<Ventas>(); 
                if (clienteId > 0)
                {
                    string sql = @"
                            select * from ventas where clientefk = @id
                        ";
                    ventas = db.Query<Ventas>(sql, new { id = clienteId }).ToList();

                } 
                else
                {

                    ventas = db.GetAll<Ventas>().ToList();
                } 

                var list = ventas.ConvertAll(venta => 
                {
                    venta.DetallesVenta = db.Query<DetallesVentas>("select * from DetallesVentas where ventafk = @id", new { id = venta.IdVenta }).ToList();
                    return venta;
                });
                return list;
            }

        }

       

      

      

      

        public bool Save(Ventas v)
        {


            long idCliente = v.Cliente.Save(v.Cliente);

            if (idCliente > 0)
            {
                v.ClienteFK = (int)idCliente;
                int idVenta = (int)Insert(v);
                if (idVenta > 0)
                {
                    if (v.TipoVentaFk == 2)
                    {
                        Referencia.InsertAll(v.Referencias);    
                    }
                        
                    return v.DetallesVenta[0].Insert(v.DetallesVenta,idVenta);

                }

            }
            return false;

        }


        public List<Ventas> GetCreditosPendientes()
        {
            using (var db = GetConnection)
            {
                string sql = "Select * from ventas where TipoVentaFk = 2";

                return db.Query<Ventas>(sql).ToList();


            }
        }
    }
}
