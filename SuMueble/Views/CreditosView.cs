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
    public partial class CreditosView : UserControl
    {
        Ventas Venta = new Ventas();
        List<Ventas> ListaVentas;
        public CreditosView()
        {
            InitializeComponent();
            GetData();


        }
        private void GetData()
        {
            ListaVentas = Venta.GetCreditosPendientes();
            CargarDataGrid(ListaVentas);

        }
        private void CargarDataGrid(List<Ventas> lista)
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
            return 0;
        }
            
        private void btn_pagarcuota_Click(object sender, EventArgs e)
        {
            int cod_factura = GetCell(0);
            if (cod_factura > 0)
            {
                PagarCuota pagarCuota = new PagarCuota(cod_factura);
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
                
                string cl = txtbuscar.Text.ToLower();
                return x.IdVenta.ToString().StartsWith(txtbuscar.Text) || x.Cliente.Nombre.ToLower().StartsWith(cl);
            }).ToList();

            CargarDataGrid(filtrados);
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            txtbuscar.Text = txtbuscar.Text.Trim();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            var manual = new Manual("creditos");
            manual.Show();
        }
    }
}
