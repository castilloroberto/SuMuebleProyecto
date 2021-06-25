using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SuMueble.Views.Prompts;
using System.Windows.Forms;
using SuMueble.Models;
using SuMueble.Controller;

namespace SuMueble.Views
{

    public partial class VentaCreditoView : UserControl
    {   //Controladores 
        ClienteControlador clienteControlador = new ClienteControlador();
        ColaboradorControlador colaboradorControlador = new ColaboradorControlador();

        //Variables
        public static List<DetallesVentas> listaProductos;
        public static List<Referencias> listaReferencias;
        public static void listaProducto(DetallesVentas dv)
        {
            listaProductos.Add(dv);
            Total += dv.SubTotal;
           
        }
        private static float Total = 0;
        public VentaCreditoView()
        {
            InitializeComponent();
            listaProductos = new List<DetallesVentas>();
            listaReferencias = new List<Referencias>();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            VentaAgregarProducto ventaAgregarProducto = new VentaAgregarProducto();
            ventaAgregarProducto.ShowDialog();
            CargarListView();
        }
        private void CargarListView()
        {
            l_monto.Text = string.Format("{0:C2}", Total);
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = listaProductos;
            lb_productosVenta.DisplayMember = "Info";
        } 
        private void btn_agregarReferencia_Click(object sender, EventArgs e)
        {
            AgregarReferencia agregarReferencia = new AgregarReferencia();
            agregarReferencia.ShowDialog();
            CargarReferencias();
        }

        private void CargarReferencias()
        {
            lb_referencias.DataSource = listaReferencias;
            lb_referencias.DisplayMember = "Nombre";
        }

        private void txt_dniCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dniCliente.Text.Length == 13)
            {
                ClearCliente();
                Clientes cliente = clienteControlador.GetCliente(txt_dniCliente.Text);
                if (cliente == null)
                {
                    HideShowLabels(true);
                }
                else
                {
                    HideShowLabels(false);
                    txt_nombreCliente.Text = cliente.Nombre;
                    txtTelefonoCliente.Text = cliente.Tel;
                }
            }
            if (txt_dniCliente.Text.Length == 0)
                ClearCliente();
        }
        private void HideShowLabels(bool visible)
        {
            labelClienteNuevo.Visible = visible;
            l_NombreCliente.Visible = visible;
            l_TelefonoCliente.Visible = visible;
            l_RTNCliente.Visible = visible;
        }
        private void ClearCliente()
        {
            txt_nombreCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
        }

        private void txt_dniColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dniColaborador.Text.Length == 13)
            {
                Colaboradores c = colaboradorControlador.GetColaborador(txt_dniColaborador.Text);
                if (c == null)
                {
                    ShowHideColaboradorLabel();
                }
                else
                {
                    ShowHideColaboradorLabel(c.Nombre, true);

                }
            }
            if (txt_dniColaborador.Text.Length == 0)
                dniColaboradorLabelError.Visible = false;

        }

        private void ShowHideColaboradorLabel(string name = "", bool flag = false)
        {
            dniColaboradorLabelError.Visible = true;
            if (flag)
            {
                dniColaboradorLabelError.Text = name;
                dniColaboradorLabelError.ForeColor = Color.FromName("Dodgerblue");


            }
            else
            {
                dniColaboradorLabelError.Text = "Escribió mal su DNI";
                dniColaboradorLabelError.ForeColor = Color.FromName("Crimson");

            }

        }
    }
}
