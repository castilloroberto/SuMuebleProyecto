﻿using Dapper.Contrib.Extensions;
using SuMueble.Models;
using SuMueble.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Controller
{
    public class ProductoControlador : DBConnection
    {
        public IEnumerable<Productos> GetProductos()
        {
            using (var DB = GetConnection)
            {
                
                return DB.GetAll<Productos>();

            }
        }

        public bool InsertProductos(Productos producto)
        {
            using (var DB = GetConnection)
            {

                return DB.Insert(producto) > 0;

            }
        }

        public bool UpdateProductos(Productos producto)
        {
            using (var DB = GetConnection)
            {

                return DB.Update(producto);

            }
        }

        public bool SaveProductos(Productos producto)
        {
           if (producto.ID == 0)
            {
                
               return InsertProductos(producto);
            }
            else
            {
               return UpdateProductos(producto);
            }
        }
    }
}