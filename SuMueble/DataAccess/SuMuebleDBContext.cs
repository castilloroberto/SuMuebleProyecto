using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SuMueble.DataAccess
{
    public class SuMuebleDBContext:DbContext
    {

        public SuMuebleDBContext():base("SuMuebleBD")
        {
            Database.SetInitializer(new SuMuebleBDInitializer());
        }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<TipoVenta> TiposVenta { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Devolucion> Devoluciones { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
        // 11 tablas



    }
}
