using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class ReferenciaController: BasicController<Referencias>
    {
      public bool InsertAll(List<Referencias> referencias)
        {
            using (var db = GetConnection)
            {
                return db.Insert(referencias) >= referencias.Count;
            }
        } 
    }
}
