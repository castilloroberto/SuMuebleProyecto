using ClosedXML.Excel;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Reportes : UserControl
    {
        Producto provider = new Producto();
        DataTable Datos = new DataTable();
        List<String> queries = new List<string>();
        public Reportes()
        {
            InitializeComponent();
            // COLABORADORES
            queries.Add("select * from colaboradores");
            // clientes
            queries.Add("select * from clientes");
            // inventario
            queries.Add(@"select p.Codigo,
                        p.NombreProducto as [Nombre Producto] ,
                        c.Categoria ,
                        Existencias ,
                        ISV,
                        case when EstadoFk = 1 
                        then 'Nuevo' 
                        else 'Usado'end as Estado
                         from productos p 
                        inner join Categorias c
                        on c.IdCategoria = p.categoriafk");
            //devoluciones
            queries.Add("select ventafk as IdVenta, " +
                "c.Nombre as Colaborador,d.Fecha,dv.productofk as IdProducto," +
                "p.NombreProducto as [Nombre Producto]," +
                "dv.Cantidad,dv.Motivo,dv.Observaciones " +
                "from devoluciones d " +
                "inner join detalledevolucion dv " +
                "on d.iddevolucion = dv.devolucionfk " +
                "inner join productos p " +
                "on p.idproducto = dv.productofk " +
                "inner join colaboradores c " +
                "on c.idcolaborador = d.colaboradorfk");
            // ventas
            queries.Add(@"select v.IdVenta,
                        c.Nombre as Cliente,
                        cl.Nombre as Colaborador,
                        v.Cuotas,
                        v.FechaFinCredito,
                        v.FechaVenta,
                        v.Prima,
                        case
                            when v.TipoVentaFk = 1 then 'Al Contado'
                            else 'Al Credito' 
                        end as [Tipo Venta],
                        p.NombreProducto as [Nombre Producto],
                        dv.PrecioVenta,
                        dv.Cantidad,
                        dv.Descuento
                        from ventas v
                        inner join detallesventas dv
                        on v.idventa = dv.ventafk 
                        inner join productos p 
                        on p.idproducto = dv.productofk
                        inner join colaboradores cl 
                        on cl.IdColaborador = v.ColaboradorFk
                        inner join Clientes c 
                        on c.IdCliente = v.ClienteFk
                            ");
            CargarDatos(queries[0]);
        }

        void CargarDatos(string query)
        {
            Datos = provider.Query(query);
            dgv_reporte.DataSource = null;
            dgv_reporte.DataSource = Datos;
        }
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            };


            var res = saveFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                try
                {

                    XLWorkbook workbook = new XLWorkbook();
                   
                    workbook.Worksheets.Add(Datos, "pagina1");
                    workbook.SaveAs(fileName);

                    MessageBox.Show($"El archivo se guardo con exito\nEl archivo se guardo en: {fileName}", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Algo Salio mal:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cb_reporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            CargarDatos(queries[cb_reporte.SelectedIndex]);
        }
    }
}
