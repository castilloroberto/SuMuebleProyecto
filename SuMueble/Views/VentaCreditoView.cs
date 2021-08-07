using System;
using System.Collections.Generic;
using SuMueble.Views.Prompts;
using System.Windows.Forms;
using SuMueble.Models;
using SuMueble.Controller;

namespace SuMueble.Views
{

    public partial class VentaCreditoView : UserControl
    {   //Controladores 
        ClienteControlador clienteControlador = new ClienteControlador();

        //Variables
        public static Guid _IDVenta;
        public static Ventas _venta;  
        public static List<DetallesVentas> listaProductos;
        public static List<Referencias> listaReferencias;
        private static float _Total = 0;
        public static void listaProducto(DetallesVentas dv)
        {
            dv.IDVenta = _IDVenta;
            listaProductos.Clear();
            listaProductos.Add(dv);
            _Total = dv.SubTotal;
           
        }

        //metodos
        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            VentaAgregarProducto ventaAgregarProducto = new VentaAgregarProducto();
            ventaAgregarProducto.ShowDialog();
            CargarListView();
        }
        private void CargarListView()
        {
            l_monto.Text = string.Format("{0:C2}", _Total);
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = listaProductos;
            lb_productosVenta.DisplayMember = "Info";
        } 
        private void btn_agregarReferencia_Click(object sender, EventArgs e)
        {
            var agregarReferencia = new AgregarReferencia();
            agregarReferencia.ShowDialog();
            CargarReferencias();
        }

        private void CargarReferencias()
        {

            lb_referencias.DataSource = null;
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
                    ActivarIndicadores();
                    labelClienteNuevo.Visible = true;
                    
                }
                else
                {
                   
                    txt_nombreCliente.Text = cliente.Nombre;
                    txtTelefonoCliente.Text = cliente.Tel;
                    txt_dirCliente.Text = cliente.Direccion;
                    txt_rtnCliente.Text = cliente.RTN;
                    ActivarIndicadores();
                    
                 }
            }
            if (txt_dniCliente.Text.Length == 0)
                ClearCliente();
        }
        private void limpiarventa()
        {
            txt_dniCliente.Clear(); ;
            _IDVenta = Guid.NewGuid();
            listaProductos.Clear();
            listaReferencias.Clear();
            _Total = 0;
            _venta = new Ventas();
            CargarListView();
            CargarReferencias();

        }
        private void ClearCliente()
        {
            txt_nombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txt_dirCliente.Clear();
            txt_rtnCliente.Clear();

            ActivarIndicadores();
        }
        private void ActivarIndicadores()
        {

            l_dir.Visible = txt_dirCliente.Text == "";
            l_NombreCliente.Visible = txt_nombreCliente.Text == "";
            l_TelefonoCliente.Visible = txtTelefonoCliente.Text == "";
            l_RTNCliente.Visible = txt_rtnCliente.Text == "";
        }



    
        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            string msg = IsAllReady() ;
            if (msg == "")
            {
                
                Clientes cliente = new Clientes()
                {
                    DNI       = txt_dniCliente.Text,
                    Direccion = txt_dirCliente.Text,
                    Nombre    = txt_nombreCliente.Text,
                    RTN       = txt_rtnCliente.Text,
                    Tel       = txtTelefonoCliente.Text

                };
                _venta = new Ventas()
                {
                    ID            = _IDVenta,
                    Cliente       = cliente,
                    DetallesVenta = listaProductos,
                    IDColaborador = Menu.colaborador.DNI,
                    Referencias   = listaReferencias,
                    IDTipoVenta   = 2,
                    //Cuotas  = 0,
                    //Prima = 0,
                    //FechaFin = DateTime.Now,


                };
                var terminar = new TerminarVentaCredito();
                terminar.ShowDialog();
                limpiarventa();
                ClearCliente();
                
            }
            else
            {
                MessageBox.Show(msg, "Campos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }
        private string IsAllReady()
        {
            string res = txt_dniCliente.Text.Length != 13 ? "* DNI Cliente" : "";
            res += txt_rtnCliente.Text.Length != 14 ? "\n* RTN de Cliente" : "";
            res += txt_nombreCliente.Text.Length < 3 ? "\n* Nombre de Cliente" : "";
            res += txtTelefonoCliente.Text.Length != 8 ? "\n* Telefono de Cliente" : "";
            res += txt_dirCliente.Text.Length < 10 ? "\n* Direccion de Cliente" : "";
            
            res += listaReferencias.Count < 2 ? "\n* Faltan Referencias" : "";

            res += listaProductos.Count != 1 ? "\n* Falta Agregar Productos a la venta" : "";


            return res;
        }
        //constructor
        public VentaCreditoView()
        {
            InitializeComponent();
            listaProductos = new List<DetallesVentas>();
            listaReferencias = new List<Referencias>();
            _IDVenta = Guid.NewGuid();
        }

        private void txt_dniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_rtnCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       

        private void btn_quitarItem_Click(object sender, EventArgs e)
        {
            int i = lb_referencias.SelectedIndex;
            if (lb_referencias.Items.Count > 0)
            {
               
                listaReferencias.RemoveAt(i);
                CargarReferencias();
               

            }
            else
            {
                MessageBox.Show("No esta permitido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
