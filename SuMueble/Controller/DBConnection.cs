using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SuMueble.Views
{
    public class DBConnection
    {
        public static string GetString()
        {
            return ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }
    }
}
