using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using Ventana_de_Inventarios;

namespace SuMueble.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            Venta ventasUc = new Venta();
            panel2.Controls.Add(ventasUc);

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
            Venta ventasUc = new Venta();
            //ventasUc.Width = panel2.Width-5;
            //ventasUc.Height = panel2.Height-5;
            panel2.Controls.Add(ventasUc);
            

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_inventario.ForeColor = Color.White;
            btn_inventario.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
            // vista
            Inventarios inventario = new Inventarios();
            panel2.Controls.Add(inventario);
        }
    

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_creditos.ForeColor = Color.White;
            btn_creditos.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
            // vista
            CreditosView creditos = new CreditosView();
            panel2.Controls.Add(creditos);
        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_devoluciones.ForeColor = Color.White;
            btn_devoluciones.BackColor = Color.DodgerBlue;
            panel2.Controls.Clear();
            // vista
            DevolucionesView devoluciones = new DevolucionesView();
            panel2.Controls.Add(devoluciones);
        }

        private void btn_historialVentas_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_historialVentas.ForeColor = Color.White;
            btn_historialVentas.BackColor = Color.DodgerBlue;
            
            // vista
            panel2.Controls.Clear();
            HistorialVentasView historial = new HistorialVentasView();
            panel2.Controls.Add(historial);
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

        

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
