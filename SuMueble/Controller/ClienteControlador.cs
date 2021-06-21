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
        public Clientes Login(string DNI, string Clave) { 
        
            using (var  DB= GetConnection)
            {

               return DB.QueryFirst<Clientes>("select from Clientes where DNI=@DNI and Clave=@Clave", new { Clave = Clave, DNI = DNI });


            }
        }

        public bool InsertCliente(Clientes cliente) {

            using (var DB = GetConnection)
            {

                return DB.Insert(cliente) > 0;


            }

        }

        public bool UpdateCliente(Clientes cliente)
        {

            using (var DB = GetConnection)
            {

                return DB.Update(cliente);


            }
        }


        /*public bool SaveCliente(Clientes cliente)
        {
            if(cliente.DNI == string.Empty)
            
        }*/
    }
}
