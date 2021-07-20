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
        DataTable venta = new DataTable();
        DataTable DetalleVenta = new DataTable();

        public Ventascontado()
        {
        }

        public Ventascontado(string cod_factura)
        {
            InitializeComponent();
            venta = ventacontrolador.GetVenta(cod_factura);
            //DetalleVenta = detalleVentaController.GetDetalleVenta(venta);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ventascontado_Load(object sender, EventArgs e)
        {

        }
    }
}
