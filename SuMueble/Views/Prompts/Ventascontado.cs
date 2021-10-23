using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SuMueble.Models;
using SuMueble.DataAccess;

namespace SuMueble.Views
{
    public partial class Ventascontado : Form
    {
        Venta venta ;

        public Ventascontado()
        {
        }

        public Ventascontado(int cod_factura)
        {
            InitializeComponent();
            using (var db = new SuMuebleDBContext())
            {

                venta = db.Ventas.Include("DetalleVenta").Where( x => x.CodigoFactura == cod_factura).First();
            }
            CargarDatos(cod_factura);
        }

        private void CargarDatos(int cod_factura )
        {
           
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ventascontado_Load(object sender, EventArgs e)
        {

        }
    }
}
