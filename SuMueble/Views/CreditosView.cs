using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class CreditosView : UserControl
    {
        VentaController ventaController = new VentaController();
        DataTable ListaVentas;
        public CreditosView()
        {
            InitializeComponent();
            ListaVentas = ventaController.GetCreditosPendientes();
            CargarDataGrid(ListaVentas);

            //foreach (var item in ListaVentas)
            //{   
            //    item.Field("")
            //}



        }
        private void CargarDataGrid(DataTable lista)
        {
            dgv_ventasCredito.DataSource = lista;
        }

        private void btn_pagarcuota_Click(object sender, EventArgs e)
        {
            PagarCuota pagarCuota = new PagarCuota();
            pagarCuota.ShowDialog();
        }
    }
}
