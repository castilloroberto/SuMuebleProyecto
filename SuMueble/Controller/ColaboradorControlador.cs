using Dapper;
using Dapper.Contrib.Extensions;
using SuMueble.Helpers;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuMueble.Controller
{
   public class ColaboradorControlador: DBConnection
    {
        private bool Insert(Colaborador c)
        {
            using (var db = GetConnection)
            {
               return db.Insert(c) >0;
            }
        }
        private bool Update(Colaborador c)
        {
            using (var db = GetConnection)
            {
                return db.Update(c);
            }
        }

        public bool Desactivar(int IdColaborador)
        {
            using (var db = GetConnection)
            {
                string sql = @$"UPDATE Colaboradores
                                        SET FechaFinContrato = GETDATE()
                                       ,Activo = 0
                                       WHERE IdColaborador = @IdColaborador ";
                return db.Execute(sql,new { IdColaborador = IdColaborador }) > 0;
            }
        }
        public void Check()
        {
            var defaultColaborador = new Colaborador()
            {
                DNI = "0703200101235",
                RTN = "0703200101235R",
                Nombre = "Robero Castillo",
                Telefono = "88137603",
                Email = "robertocastillo945@gmail.com",
                FechaNacimiento = new DateTime(2000, 08, 31),
                Clave = Security.Encrypt("123"),
                PuestoFk = 1
            };
            Save(defaultColaborador);
           
        }

        public  Colaborador Get(string DNI)
        {
            using (var db = GetConnection)
            {
                string sql = "select * from Colaboradores where dni = @dni";
                try
                {
                    return db.Query<Colaborador>(sql,new { dni=DNI}).First();

                }
                catch (Exception)
                {
                    return null;
                }
                
            }
        }
        public bool Save(Colaborador c)
        {
            var Colaborador = Get(c.DNI);
            if (Colaborador == null)
            {
               return Insert(c);
            }
            else
            {
               return Update(c);
            }
        }

        public bool Login(string DNI="0", string clave="0")
        {
            bool ok = false;
            using (var DB=GetConnection)
            {
                Colaborador colaborador = DB.Get<Colaborador>(DNI);

                if (colaborador != null)
                    ok = colaborador.Clave == clave;

                return ok;
            }
        }
        public List<Colaborador> GetAll() //obtener lista de colaboradores
        {
            using (var db = GetConnection)
            {
                
                var colaboradores = db.GetAll<Colaborador>().ToList();
                var res = colaboradores.ConvertAll(c => {
                    c.Puesto = db.Get<Puestos>(c.PuestoFk);
                    return c;
                });

                res.Reverse();
                return res;
            }
        }
    }


}
