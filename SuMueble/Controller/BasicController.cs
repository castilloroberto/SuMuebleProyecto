using Dapper.Contrib.Extensions;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuMueble.Controller
{
    public class BasicController<T>: DBConnection where T:class
    {
        public DataTable Query(string query)
        {
            var res = new DataTable();
            var conn = GetConnection;
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            res.Load(reader);
            conn.Close();
            return res;

        }
        public T Get(int id)
        {
            using (var db = GetConnection)
            {
                return db.Get<T>(id);
            }
        }

        public List<T> GetAll()
        {
            using (var db = GetConnection)
            {
                return db.GetAll<T>().ToList();
            }
        }
        public long Insert(T t)
        {
            using (var db = GetConnection)
            {
                return db.Insert<T>(t);
            }
        }
        public bool Update(T t)
        {
            using (var db = GetConnection)
            {
                return db.Update<T>(t);
            }
        }
      




    }
}
