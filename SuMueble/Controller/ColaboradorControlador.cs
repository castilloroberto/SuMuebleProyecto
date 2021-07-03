using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
   public class ColaboradorControlador: DBConnection
    {
        private bool InsertColaborador(Colaboradores c)
        {
            using (var db = GetConnection)
            {
               return db.Insert<Colaboradores>(c) >0;
            }
        }
        private bool UpdateColaborador(Colaboradores c)
        {
            using (var db = GetConnection)
            {
                return db.Update<Colaboradores>(c);
            }
        }
        public Colaboradores GetColaborador(string DNI)
        {
            using (var db = GetConnection)
            {
                return db.Get<Colaboradores>(DNI);
            }
        }
        public bool SaveColaborador(Colaboradores c)
        {
            Colaboradores Colaborador = GetColaborador(c.DNI);
            if (Colaborador == null)
            {
               return InsertColaborador(c);
            }
            else
            {
               return UpdateColaborador(c);
            }
        }

        public bool Login(string DNI="0", string clave="0")
        {
            bool ok = false;
            using (var DB=GetConnection)
            {
                Colaboradores colaborador = DB.Get<Colaboradores>(DNI);

                if (colaborador != null)
                    ok = colaborador.Clave == clave;

                return ok;
            }
        }
        public IEnumerable<Colaboradores> Colaboradores() //obtener lista de colaboradores
        {
            using (var db = GetConnection)
            {
                return db.GetAll<Colaboradores>();
            }
        }
    }


}
