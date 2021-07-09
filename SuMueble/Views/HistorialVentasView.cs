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
        ClienteControlador clienteControlador = new ClienteControlador();
        List<Clientes> clientes;

        bool toogle = true;
        public HistorialVentasView()
        {
            InitializeComponent();
            dvg_ventas.AutoGenerateColumns = false;
            dvg_ventas.DataSource = ventaController.ObtenerVenta();
            dvg_ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

   

        private void HistorialVentasView_Load(object sender, EventArgs e)
        {

        }

        private void btn_verDetalle_Click(object sender, EventArgs e)
        {
            toogle = !toogle;

            VentaCredito ventaCredito = new VentaCredito();
            Ventascontado ventascontado = new Ventascontado();
            if (toogle)
                ventascontado.ShowDialog();
            else
                ventaCredito.ShowDialog();


        }

        public void txt_BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_BuscarCliente.Text.ToLower();

            //List<Clientes> filtrados = clientes.Where<Clientes>(x => {

                


            //}).ToList();

            dvg_ventas.DataSource = null;
            //dvg_ventas.DataSource = filtrados;
        }
    }
}
