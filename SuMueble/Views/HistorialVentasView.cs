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
    public partial class HistorialVentasView : UserControl
    {
        List<Venta> ventas;
        List<DetalleVenta> detalles;

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
            using (var db = new SuMuebleDBContext())
            {
                ventas = db.Ventas.ToList();
                detalles = db.DetallesVenta.ToList();

            }
            
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

            List<Venta> filtrados = ventas.Where(x => {

                return x.Cliente.Nombre.ToLower().StartsWith(buscar);


            }).ToList();

            dvg_ventas.DataSource = null;
            dvg_ventas.DataSource = filtrados;
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVenta = cb_filtro.Text;

            if (tipoVenta != "Todo")
            {
                List<Venta> filtrados = ventas.Where<Venta>(x =>
                {

                    return x.TipoVenta.Nombre == tipoVenta;

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
