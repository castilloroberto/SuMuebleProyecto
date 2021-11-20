using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class ClientesView : UserControl
    {
        ClienteControlador ClienteControlador = new ClienteControlador();
        List<Clientes> Clientes = new List<Clientes>();

        public ClientesView()
        {
            InitializeComponent();
            LoadClientes();
        }
        void LoadClientes()
        {
            Clientes = ClienteControlador.IncludeCompras();
            LoadDGV(Clientes);
        }
        void LoadDGV(List<Clientes> clientes)
        {
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = clientes;
            total_clientes.Text = $"Total Clientes: {clientes.Count}";

        }
        private void txt_buscar_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            var clientesPorNombre = Clientes.Where(user => {

                return user.Nombre.ToLower().Contains(txt_buscar_nombre.Text.ToLower());
            }).ToList();

            LoadDGV(clientesPorNombre);
        }

        private void txt_direccion_KeyUp(object sender, KeyEventArgs e)
        {
            var clientesPorDir = Clientes.Where(user => {
                if (user.Direccion != null)
                {
                    return user.Direccion.ToLower().Contains(txt_direccion.Text.ToLower());
                }
                return false;
            }).ToList();

            if (txt_direccion.Text == "")
            {
                LoadDGV(Clientes);
            } 
                else
            {
                LoadDGV(clientesPorDir);

            }
        }

        private void btn_monto_minimo_Click(object sender, EventArgs e)
        {
            var clientesPorMontoMinimo = Clientes.Where(cliente => {

                return cliente.MontoInvertido >= (float)n_monto_minimo.Value;
            }).ToList();

            LoadDGV(clientesPorMontoMinimo);
        }

        

        private void dtp_cliente_desde_CloseUp(object sender, EventArgs e)
        {
            var clientesAntesDe = Clientes.Where(cliente => {
                // si retorna algo menor a cero el *valor del parametro* es menor a el valor del objecto
                // -1 = dpt <  registrado* 
                // 0 = registrado == dpt 
                // 1 = registrado < dpt 
                int n = cliente.Registrado.CompareTo(dtp_cliente_desde.Value);
                return n == -1;
                
             }).ToList();

            LoadDGV(clientesAntesDe);
        }

        private void btn_ver_todos_Click(object sender, EventArgs e)
        {
            LoadDGV(Clientes);

        }
    }
}
