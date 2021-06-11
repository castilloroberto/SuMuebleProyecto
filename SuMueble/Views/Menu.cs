using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void HideAll()
        {

            btn_ventas.ForeColor = Color.FromName("ControlText");
            btn_ventas.BackColor = Color.FromName("ControlLight");
            btn_inventario.ForeColor = Color.FromName("ControlText");
            btn_inventario.BackColor = Color.FromName("ControlLight");
            btn_creditos.ForeColor = Color.FromName("ControlText");
            btn_creditos.BackColor = Color.FromName("ControlLight");
            btn_devoluciones.ForeColor = Color.FromName("ControlText");
            btn_devoluciones.BackColor = Color.FromName("ControlLight");
            btn_historialVentas.ForeColor = Color.FromName("ControlText");
            btn_historialVentas.BackColor = Color.FromName("ControlLight");
            btn_colaboradores.ForeColor = Color.FromName("ControlText");
            btn_colaboradores.BackColor = Color.FromName("ControlLight");
            btn_clientes.ForeColor = Color.FromName("ControlText");
            btn_clientes.BackColor = Color.FromName("ControlLight");
            btn_cerrarSesion.ForeColor = Color.FromName("ControlText");
            btn_cerrarSesion.BackColor = Color.FromName("OrangeRed");


        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            // quita el color del bton seleccionado antes
            HideAll();
            // establece el color de selccionado de la letra
            btn_ventas.ForeColor = Color.White;
            // establece el color de selccionado
            btn_ventas.BackColor = Color.DodgerBlue;
            //UserControl
            panel2.Controls.Clear();
            Venta uc = new Venta();
            panel2.Controls.Add(uc);
            

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_inventario.ForeColor = Color.White;
            btn_inventario.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_creditos.ForeColor = Color.White;
            btn_creditos.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_devoluciones.ForeColor = Color.White;
            btn_devoluciones.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
        }

        private void btn_historialVentas_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_historialVentas.ForeColor = Color.White;
            btn_historialVentas.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_colaboradores.ForeColor = Color.White;
            btn_colaboradores.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
            ColaboradoresView uc = new ColaboradoresView();
            panel2.Controls.Add(uc);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_clientes.ForeColor = Color.White;
            btn_clientes.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_cerrarSesion.ForeColor = Color.White;
            btn_cerrarSesion.BackColor = Color.OrangeRed;
            panel2.Controls.Clear();
        }
    }
}
