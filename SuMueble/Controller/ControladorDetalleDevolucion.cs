using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class ControladorDetalleDevolucion:DBConnection
    {
        public bool InsertarDetalleDevolucion(List<DetalleDevolucion>detalles)
        {
            using (var db=GetConnection)
            {

                return db.Insert(detalles) >detalles.Count;

            }
           
        }
    }
}
