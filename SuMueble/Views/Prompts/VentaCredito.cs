using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class VentaCredito : Form
    {
        VentaController ventacontrolador = new VentaController();
        PagoControlador pagoControlador = new PagoControlador();
        DetalleVentaController detalleVentaController = new DetalleVentaController();
        DataRow venta;
        DataTable DetalleVenta;
        public VentaCredito()
        {
        }

        public VentaCredito(string cod_factura)
        {
            InitializeComponent();
            venta = ventacontrolador.GetVenta(cod_factura);
            DetalleVenta = detalleVentaController.GetDetalleVenta(int.Parse(cod_factura));
            CargarDatos(cod_factura);
        }

        private void CargarDatos(string cod_factura)
        {
            var venta_ = ventacontrolador.GetVentaID(cod_factura);
            txt_cliente.Text = venta_.Cliente.Nombre;
            txt_cuotasPendientes.Text = venta.Field<int>("Cuotas").ToString();
            var creditopendiente = pagoControlador.GetCreditoPendiente(int.Parse(cod_factura));

            if (creditopendiente.Rows.Count > 0)
            {
                txt_montoPendiente.Text = creditopendiente.Rows[0].Field<double>("Pendiente").ToString();

            }
            else
            {
                txt_montoPendiente.Text = DetalleVenta.Rows[0].Field<double>("SubTotal").ToString();
            }
            var res = pagoControlador.GetPagado(ventacontrolador.GetVentaDapper(int.Parse(cod_factura)));
            if (res != null && res != 0)
            {
                txt_montoPagado.Text = res.ToString();
            }
            else
            {
                txt_montoPagado.Text = "0";
            }
            dgv_articulo.DataSource = DetalleVenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VentaCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
