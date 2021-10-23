using SuMueble.DataAccess;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class VentaCredito : Form
    {
        Venta venta;
        List<DetalleVenta> DetalleVenta;
        public VentaCredito()
        {
        }

        public VentaCredito(int cod_factura)
        {
            InitializeComponent();

            using (var db = new SuMuebleDBContext())
            {
                venta = db.Ventas.Find(cod_factura);
                DetalleVenta = db.DetallesVenta.Where( x=> x.CodigoFactura == cod_factura).ToList();

            }
            CargarDatos(cod_factura);
        }

        private void CargarDatos(int cod_factura)
        {

            
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
