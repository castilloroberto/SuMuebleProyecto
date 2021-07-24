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
using System.Linq;

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
            cb_filtro.SelectedIndex = 0;




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
            string tipoVenta = cb_filtro.Text;

            if (tipoVenta != "Todo")
            {
                List<Ventas> filtrados = ListaVentas.Where(x =>
                {

                    return x.TipoVenta == tipoVenta;

                }).ToList();

                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = filtrados;
            }
            else
            {
                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = ListaVentas;
            }
        }

        private void cb_filtro_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
