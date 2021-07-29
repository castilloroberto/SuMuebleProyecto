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
        List<Ventas> ventas;
        public DevolucionesView()
        {
            InitializeComponent();
            dvg_devoluciones.AutoGenerateColumns = false;

            ventas = ventaController.ObtenerVenta().ToList();
            dvg_devoluciones.DataSource = ventas;
            cb_filtro.SelectedIndex = 0;


        }
        private string GetCell(int cell)
        {
            int index = dvg_devoluciones.CurrentRow.Index;
            return dvg_devoluciones.Rows[index].Cells[cell].Value.ToString();
        }
        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            int codigofactura_ = int.Parse(GetCell(0));

            var ventaGuid = ventaController.GetVentaDapper(codigofactura_);
           
            Devolucion devolucion = new Devolucion(ventaGuid);
            devolucion.ShowDialog();
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscarCliente_TextChanged_1(object sender, EventArgs e)
        {
            string buscar = txt_buscarCliente.Text.ToLower();

            List<Ventas> filtrados = ventas.Where<Ventas>(x => {

                return x.NombreCliente.ToLower().StartsWith(buscar);


            }).ToList();

            dvg_devoluciones.DataSource = null;
            dvg_devoluciones.DataSource = filtrados;
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

                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = filtrados;
            }
            else
            {
                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = ventas;
            }
        }
    }
}
