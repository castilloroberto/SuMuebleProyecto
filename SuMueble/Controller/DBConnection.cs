using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace SuMueble.Views
{
    public class DBConnection
    {
        protected SqlConnection GetConnection => new SqlConnection(ConnectionString);
        

        private string ConnectionString => ConfigurationManager.ConnectionStrings["SuMuebleDB"].ConnectionString;
    }
}
