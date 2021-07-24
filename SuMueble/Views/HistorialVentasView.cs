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
        List<Ventas> ventas;

        //bool toogle = true;
        public HistorialVentasView()
        {
            InitializeComponent();
            dvg_ventas.AutoGenerateColumns = false;
            ventas = ventaController.ObtenerVenta().ToList();
            dvg_ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_ventas.DataSource = ventas;
            cb_filtro.SelectedIndex = 0;
        }

   

        private void HistorialVentasView_Load(object sender, EventArgs e)
        {

        }

        private string GetCell(int cell)
        {
            int index = dvg_ventas.CurrentRow.Index;
            return dvg_ventas.Rows[index].Cells[cell].Value.ToString();
        }

        private void btn_verDetalle_Click(object sender, EventArgs e)
        {

            var codigofactura = GetCell(0);
            VentaCredito ventaCredito = new VentaCredito(codigofactura);
            Ventascontado ventascontado = new Ventascontado(codigofactura);
            string tipoVenta = GetCell(1);
            if (tipoVenta == "Al Contado")
                ventascontado.ShowDialog();
            else
                ventaCredito.ShowDialog();


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
    }
}
