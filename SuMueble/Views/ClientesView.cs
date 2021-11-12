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
        VentaController VentaControlador = new VentaController();
        List<Clientes> Clientes = new List<Clientes>();

        public ClientesView()
        {
            InitializeComponent();
            LoadClientes();
        }
        void LoadClientes()
        {
            Clientes = ClienteControlador.GetAll();
            LoadDGV(Clientes);
        }
        void LoadDGV(List<Clientes> clientes)
        {
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = clientes;
        }
        private void txt_buscar_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            var clientesPorNombre = Clientes.Where(user => {

                return user.Nombre.ToLower().StartsWith(txt_buscar_nombre.Text.ToLower());
            }).ToList();

            LoadDGV(clientesPorNombre);
        }
    }
}
