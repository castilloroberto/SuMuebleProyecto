using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class ClienteControlador: DBConnection
    {
        public List<Clientes> GetClientesCompras()
        {
            return null;
        } 

        public List<Clientes> GetAll()
        {
            using (var db = GetConnection)
                return db.GetAll<Clientes>().AsList();
        }
        public Clientes Login(string DNI, string Clave) { 
        
            using (var  DB= GetConnection)
            {

               return DB.QueryFirst<Clientes>("select from Clientes where DNI=@DNI and Clave=@Clave", new { Clave = Clave, DNI = DNI });


            }
        }

        private bool InsertCliente(Clientes cliente) {

            List<Clientes> clientes = new List<Clientes>()
            {
                cliente
            };
            using (var DB = GetConnection)
            {

                return DB.Insert(clientes) > 0;


            }

        }

        private bool UpdateCliente(Clientes cliente)
        {

            using (var DB = GetConnection)
            {

                return DB.Update(cliente);


            }
        }

        public Clientes GetCliente(string DNI)
        {
            using (var db = GetConnection)
            {
                return db.Get<Clientes>(DNI);
            }
        }
        public bool SaveCliente(Clientes cliente)
        {
            
            Clientes c = GetCliente(cliente.DNI);
            if (c != null)
            {
                return UpdateCliente(cliente);
            }
            else
            {
                return InsertCliente(cliente);
            }

           
        }
    }
}
