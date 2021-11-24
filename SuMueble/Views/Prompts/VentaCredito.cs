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

        public VentaCredito(int idVenta)
        {
            InitializeComponent();
            
        }

        private void CargarDatos(int idVenta)
        {
            var venta_ = ventacontrolador.Get(idVenta);
            txt_cliente.Text = venta_.Cliente.Nombre;
            txt_cuotasPendientes.Text = venta.Field<int>("Cuotas").ToString();
            var creditopendiente = pagoControlador.GetCreditoPendiente(idVenta);

            if (creditopendiente.Rows.Count > 0)
            {
                txt_montoPendiente.Text = creditopendiente.Rows[0].Field<double>("Pendiente").ToString();

            }
            else
            {
                txt_montoPendiente.Text = DetalleVenta.Rows[0].Field<double>("SubTotal").ToString();
            }
           
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
