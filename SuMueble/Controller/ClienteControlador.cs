using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class ClienteControlador: BasicController<Clientes>
    {
        public List<Clientes> IncludeCompras()
        {
            var ventaController = new VentaController();

            using (var db = GetConnection)
            { 

                var clientes = db.GetAll<Clientes>().AsList();
                var list = clientes.ConvertAll(cliente =>
                {
                    
                    cliente.Compras = ventaController.IncludeDetalles(cliente.IdCliente);
                    return cliente;
                });

                return list;
            }
        } 
        public Clientes GetByDNI(string dni)
        {
            using (var db = GetConnection)
            {
                string sql = "select * from clientes where dni = @dni";
                var res = db.Query<Clientes>(sql, new { dni = dni }).ToList();
                return res.Count > 0 ? res[0] : null;
            }
        }
       
       

        private long Insert(Clientes cliente) {

            List<Clientes> clientes = new List<Clientes>()
            {
                cliente
            };
            using (var DB = GetConnection)
            {

                return DB.Insert(clientes);


            }

        }

        private long Update(Clientes cliente)
        {

            using (var DB = GetConnection)
            {

                return DB.Update(cliente) ? cliente.IdCliente : 0;


            }
        }

     
        public long Save(Clientes cliente)
        {
            
            Clientes c = Get(cliente.IdCliente);
            if (c != null)
            {
                return Update(cliente);
            }
            else
            {
                return Insert(cliente);
            }

           
        }
    }
}
