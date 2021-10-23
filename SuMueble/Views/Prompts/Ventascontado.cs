using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace SuMueble.Views
{
    public partial class Ventascontado : Form
    {
        VentaController ventacontrolador = new VentaController();
        DetalleVentaController detalleVentaController = new DetalleVentaController();
        DataRow venta ;
        DataTable DetalleVenta ;

        public Ventascontado()
        {
        }

        public Ventascontado(string cod_factura)
        {
            InitializeComponent();
            venta = ventacontrolador.GetVenta(cod_factura);
            DetalleVenta = detalleVentaController.GetDetalleVenta(int.Parse( cod_factura));
            CargarDatos(cod_factura);
        }

        private void CargarDatos(string cod_factura )
        {
            var venta_ = ventacontrolador.GetVentaID(cod_factura);
            txt_cliente.Text = venta_.NombreCliente;
            txt_DNIcliente.Text = venta.Field<string>("IDCliente");
            txt_monto.Text = venta_.TotalVenta.ToString();
            dgv_articulos.DataSource = DetalleVenta;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ventascontado_Load(object sender, EventArgs e)
        {

        }
    }
}
