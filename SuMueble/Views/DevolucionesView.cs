using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class DevolucionesView : UserControl
    {
        VentaController ventaController = new VentaController();
        IEnumerable<Ventas> ListaVentas;
        public DevolucionesView()
        {
            InitializeComponent();
            ListaVentas = ventaController.ObtenerVenta();
            dvg_devoluciones.AutoGenerateColumns = false;
            dvg_devoluciones.DataSource = ListaVentas;
            dvg_devoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }

        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = new Devolucion();
            devolucion.ShowDialog();
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            }
    }
}
