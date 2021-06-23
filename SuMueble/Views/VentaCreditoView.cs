using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SuMueble.Views.Prompts;
using System.Windows.Forms;
using SuMueble.Models;

namespace SuMueble.Views
{
    public partial class VentaCreditoView : UserControl
    {
        public static List<DetallesVentas> listaProductos;
        public static void listaProducto(DetallesVentas dv)
        {
            listaProductos.Add(dv);
            Total += dv.SubTotal;
           
        }
        private static float Total = 0;
        public VentaCreditoView()
        {
            InitializeComponent();
            listaProductos = new List<DetallesVentas>();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            VentaAgregarProducto ventaAgregarProducto = new VentaAgregarProducto();
            ventaAgregarProducto.ShowDialog();
            CargarListView();
        }
        private void CargarListView()
        {
            l_monto.Text = string.Format("{0:C2}", Total);
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = listaProductos;
            lb_productosVenta.DisplayMember = "Info";
        } 
        private void btn_agregarReferencia_Click(object sender, EventArgs e)
        {
            AgregarReferencia agregarReferencia = new AgregarReferencia();
            agregarReferencia.ShowDialog();
        }
    }
}
