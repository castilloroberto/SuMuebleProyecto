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
    public partial class CreditosView : UserControl
    {
        List<Venta> ListaVentas;
        public CreditosView()
        {
            InitializeComponent();
            GetData();


        }
        private void GetData()
        {
            using (var db = new SuMuebleDBContext())
            {
                ListaVentas = db.Ventas
                    .Include("Colaborador")
                    .Include("Cliente")
                    .Include("TipoVenta")
                    .Include("DetallesVenta")
                    .Include("DetallesVenta.Producto")
                    .Include("Pagos")
                    .Where(x => x.TipoVentaId == 2) // TipoVentaId = 2 = Al Credito 
                    .ToList();

            }
            CargarDataGrid(ListaVentas);

        }
        private void CargarDataGrid(List<Venta> lista)
        {

            dgv_ventasCredito.DataSource = lista;
        }


        private dynamic GetCell(int cell)
        {
            if (dgv_ventasCredito.Rows.Count > 0)
            {
                int index = dgv_ventasCredito.CurrentRow.Index;
                return dgv_ventasCredito.Rows[index].Cells[cell].Value;

            }
            else return 0;
        }
            
        private void btn_pagarcuota_Click(object sender, EventArgs e)
        {
            int cod_factura = GetCell(0);
            if (cod_factura != 0)
            {
                var venta = ListaVentas.Find(x => x.CodigoFactura == cod_factura);
                if (venta.CuotasPagadas == venta.Cuotas)
                {
                    MessageBox.Show("La Venta No Tiene Pagos Pendientes","Pagar Cuota",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                PagarCuota pagarCuota = new PagarCuota(venta);
                pagarCuota.ShowDialog();
                GetData();

            }
            else
            {
                MessageBox.Show("No hay ningúna venta seleccionada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            var filtrados = ListaVentas.Where(x =>
            {
                int cf = 0;
                int.TryParse(txtbuscar.Text, out cf);
                string cl = txtbuscar.Text.ToLower();
                return x.CodigoFactura == cf || x.Cliente.Nombre.ToLower().StartsWith(cl);
            }).ToList();

            CargarDataGrid(filtrados);
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            txtbuscar.Text = txtbuscar.Text.Trim();
        }
    }
}
