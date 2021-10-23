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
using SuMueble.DataAccess;

namespace SuMueble.Views
{
    public partial class DevolucionesView : UserControl
    {
        List<Models.Devolucion> Devoluciones;
        public DevolucionesView()
        {
            InitializeComponent();
            using (var db = new SuMuebleDBContext())
            {
                Devoluciones = db.Devoluciones.ToList();

            }
            dvg_devoluciones.DataSource = Devoluciones;
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
              
                Devolucion devolucion = new Devolucion(codigofactura_);
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

            List<Models.Devolucion> filtrados = Devoluciones.Where(x => {

                return x.Venta.Cliente.Nombre.ToLower().StartsWith(buscar);


            }).ToList();

            dvg_devoluciones.DataSource = null;
            dvg_devoluciones.DataSource = filtrados;
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVenta = cb_filtro.Text;

            if (tipoVenta != "Todo")
            {
                List<Models.Devolucion> filtrados = Devoluciones.Where(x =>
                {

                    return x.Venta.TipoVenta.Nombre == tipoVenta;

                }).ToList();

                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = filtrados;
            }
            else
            {
                dvg_devoluciones.DataSource = null;
                dvg_devoluciones.DataSource = Devoluciones;
            }
        }

        private void txt_buscarCliente_Leave(object sender, EventArgs e)
        {
            txt_buscarCliente.Text = txt_buscarCliente.Text.Trim();
        }
    }
}
