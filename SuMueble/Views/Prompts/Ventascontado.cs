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

        public Ventascontado(int VentaId)
        {
            InitializeComponent();
        }

        private void CargarDatos(int idVenta )
        {
            var venta_ = ventacontrolador.Get(idVenta);
            txt_cliente.Text = venta_.Cliente.Nombre;
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
