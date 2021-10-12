namespace SuMueble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(maxLength: 255),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Int(nullable: false),
                        Impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        DNI = c.String(nullable: false, maxLength: 13),
                        RTN = c.String(maxLength: 14),
                        Nombre = c.String(maxLength: 100),
                        Direccion = c.String(maxLength: 200),
                        Telefono = c.String(maxLength: 8),
                        FechaRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DNI);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        CodigoFactura = c.Int(nullable: false, identity: true),
                        ColaboradorDNI = c.String(maxLength: 13),
                        ClienteDNI = c.String(maxLength: 13),
                        TipoVentaId = c.Int(nullable: false),
                        Prima = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cuotas = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoFactura)
                .ForeignKey("dbo.Clientes", t => t.ClienteDNI)
                .ForeignKey("dbo.Colaboradores", t => t.ColaboradorDNI)
                .ForeignKey("dbo.TiposVenta", t => t.TipoVentaId, cascadeDelete: true)
                .Index(t => t.ColaboradorDNI)
                .Index(t => t.ClienteDNI)
                .Index(t => t.TipoVentaId);
            
            CreateTable(
                "dbo.Colaboradores",
                c => new
                    {
                        DNI = c.String(nullable: false, maxLength: 13),
                        RTN = c.String(maxLength: 14),
                        Nombre = c.String(maxLength: 100),
                        Direccion = c.String(maxLength: 200),
                        Email = c.String(maxLength: 320),
                        Telefono = c.String(maxLength: 8),
                        Clave = c.String(maxLength: 255),
                        PuestoId = c.Int(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        FechaContratado = c.DateTime(nullable: false),
                        FechaFinContrato = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DNI)
                .ForeignKey("dbo.Puestos", t => t.PuestoId, cascadeDelete: true)
                .Index(t => t.PuestoId);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColaboradorDNI = c.String(maxLength: 13),
                        CodigoFactura = c.Int(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colaboradores", t => t.ColaboradorDNI)
                .ForeignKey("dbo.Ventas", t => t.CodigoFactura, cascadeDelete: true)
                .Index(t => t.ColaboradorDNI)
                .Index(t => t.CodigoFactura);
            
            CreateTable(
                "dbo.Puestos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetallesVenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoFactura = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Int(nullable: false),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.CodigoFactura, cascadeDelete: true)
                .Index(t => t.CodigoFactura)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Referencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoFactura = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 50),
                        ReferenciaDNI = c.String(maxLength: 13),
                        Telefono = c.String(maxLength: 8),
                        Direccion = c.String(maxLength: 255),
                        ReciboENEE = c.String(maxLength: 6),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ventas", t => t.CodigoFactura, cascadeDelete: true)
                .Index(t => t.CodigoFactura);
            
            CreateTable(
                "dbo.TiposVenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devoluciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoFactura = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Motivo = c.String(maxLength: 100),
                        Observaciones = c.String(maxLength: 255),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.CodigoFactura, cascadeDelete: true)
                .Index(t => t.CodigoFactura)
                .Index(t => t.ProductoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devoluciones", "CodigoFactura", "dbo.Ventas");
            DropForeignKey("dbo.Devoluciones", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Ventas", "TipoVentaId", "dbo.TiposVenta");
            DropForeignKey("dbo.Referencias", "CodigoFactura", "dbo.Ventas");
            DropForeignKey("dbo.DetallesVenta", "CodigoFactura", "dbo.Ventas");
            DropForeignKey("dbo.DetallesVenta", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Ventas", "ColaboradorDNI", "dbo.Colaboradores");
            DropForeignKey("dbo.Colaboradores", "PuestoId", "dbo.Puestos");
            DropForeignKey("dbo.Pagos", "CodigoFactura", "dbo.Ventas");
            DropForeignKey("dbo.Pagos", "ColaboradorDNI", "dbo.Colaboradores");
            DropForeignKey("dbo.Ventas", "ClienteDNI", "dbo.Clientes");
            DropForeignKey("dbo.Productos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Devoluciones", new[] { "ProductoId" });
            DropIndex("dbo.Devoluciones", new[] { "CodigoFactura" });
            DropIndex("dbo.Referencias", new[] { "CodigoFactura" });
            DropIndex("dbo.DetallesVenta", new[] { "ProductoId" });
            DropIndex("dbo.DetallesVenta", new[] { "CodigoFactura" });
            DropIndex("dbo.Pagos", new[] { "CodigoFactura" });
            DropIndex("dbo.Pagos", new[] { "ColaboradorDNI" });
            DropIndex("dbo.Colaboradores", new[] { "PuestoId" });
            DropIndex("dbo.Ventas", new[] { "TipoVentaId" });
            DropIndex("dbo.Ventas", new[] { "ClienteDNI" });
            DropIndex("dbo.Ventas", new[] { "ColaboradorDNI" });
            DropIndex("dbo.Productos", new[] { "CategoriaId" });
            DropTable("dbo.Devoluciones");
            DropTable("dbo.TiposVenta");
            DropTable("dbo.Referencias");
            DropTable("dbo.DetallesVenta");
            DropTable("dbo.Puestos");
            DropTable("dbo.Pagos");
            DropTable("dbo.Colaboradores");
            DropTable("dbo.Ventas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
