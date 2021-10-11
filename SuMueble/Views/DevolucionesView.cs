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
        List<Venta> ventas;
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
            if (dvg_devoluciones.Rows.Count > 0)
            {
                int index = dvg_devoluciones.CurrentRow.Index;
                return dvg_devoluciones.Rows[index].Cells[cell].Value.ToString();

            }
            else
            {
                return "0";
            }
        }
        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            int codigofactura_ = int.Parse(GetCell(0));
            if (codigofactura_ != 0)
            {
                var ventaGuid = ventaController.GetVentaDapper(codigofactura_);
           
                Devolucion devolucion = new Devolucion(ventaGuid);
                devolucion.ShowDialog();

            } else
            {
                MessageBox.Show("No hay ningún producto seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscarCliente_TextChanged_1(object sender, EventArgs e)
        {
            string buscar = txt_buscarCliente.Text.ToLower();

            List<Venta> filtrados = ventas.Where<Venta>(x => {

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
                List<Venta> filtrados = ventas.Where<Venta>(x =>
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
