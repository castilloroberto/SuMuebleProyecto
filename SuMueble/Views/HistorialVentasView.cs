using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SuMueble.Models;

namespace SuMueble.Views
{
    public partial class HistorialVentasView : UserControl
    {
        VentaController ventaController = new VentaController();
        DetalleVentaController dvController = new DetalleVentaController();
        List<Ventas> ventas;
        List<DetallesVentas> detalles;

        //bool toogle = true;
        public HistorialVentasView()
        {
            InitializeComponent();
            dvg_ventas.AutoGenerateColumns = false;
            dvg_ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargardataGrid();

            dvg_ventas.DataSource = ventas;
            cb_filtro.SelectedIndex = 0;
        }

        void CargardataGrid()
        {
            ventas = ventaController.ObtenerVenta().ToList();
            detalles = dvController.ObtenerDetalles();
            
        }

        private void HistorialVentasView_Load(object sender, EventArgs e)
        {

        }

        private string GetCell(int cell)
        {
            if (dvg_ventas.Rows.Count > 0)
            {
                int index = dvg_ventas.CurrentRow.Index;
                return dvg_ventas.Rows[index].Cells[cell].Value.ToString();

            }
            else
                return "0";
        }

        private void btn_verDetalle_Click(object sender, EventArgs e)
        {
            var codigofactura = GetCell(0);
            if (codigofactura != "0")
            {
                var ventaCredito = new VentaCredito(codigofactura);
                var ventascontado = new Ventascontado(codigofactura);
                string tipoVenta = GetCell(1);
                if (tipoVenta == "Al Contado")
                    ventascontado.ShowDialog();
                else
                    ventaCredito.ShowDialog();

            }
            else
            {
                MessageBox.Show("No hay ningúna venta seleccionada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void txt_BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_BuscarCliente.Text.ToLower();

            List<Ventas> filtrados = ventas.Where<Ventas>(x => {

                return x.NombreCliente.ToLower().StartsWith(buscar);


            }).ToList();

            dvg_ventas.DataSource = null;
            dvg_ventas.DataSource = filtrados;
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVenta = cb_filtro.Text;

            if (tipoVenta != "Todo")
            {
                List<Ventas> filtrados = ventas.Where<Ventas>(x =>
                {

                    return x.TipoVenta == tipoVenta;

                }).ToList();

                dvg_ventas.DataSource = null;
                dvg_ventas.DataSource = filtrados;
            }
            else
            {
                dvg_ventas.DataSource = null;
                dvg_ventas.DataSource = ventas;
            }
        }

        private void txt_BuscarCliente_Leave(object sender, EventArgs e)
        {
            txt_BuscarCliente.Text = txt_BuscarCliente.Text.Trim();
        }
    }
}
