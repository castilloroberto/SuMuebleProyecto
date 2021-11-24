using Dapper.Contrib.Extensions;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuMueble.Controller
{
    public class BasicController<T>: DBConnection where T:class
    {
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
