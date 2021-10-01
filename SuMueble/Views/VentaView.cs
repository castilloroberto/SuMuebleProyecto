using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SuMueble.Controller;
using SuMueble.Models;
using SuMueble.Views.Prompts;

namespace SuMueble.Views
{
    public partial class VentaView : UserControl
    {
        //controladores
        ClienteControlador clienteControlador = new ClienteControlador();
        VentaController ventaController = new VentaController();
        List<Productos> productos;
        ProductoControlador pc = new ProductoControlador();

        //variables
        private float Total = 0;
        private List<DetallesVentas> _detallesVenta = new List<DetallesVentas>();
        private string _msg = "1. Seleccione un producto\n2. Indique la cantidad que se venderá\n3. Asegurese de No borrar el precio del producto de el cuadro de texto en la parte inferior";
        private Guid _IDVenta;

        // metodos
        public VentaView()
        {
            InitializeComponent();
            CargarDataGrid();
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _IDVenta = Guid.NewGuid();
        }
        private void CargarDataGrid()
        {
            dgv_productos.AutoGenerateColumns = false;                        
            productos = pc.GetProductos().ToList();
            dgv_productos.DataSource = productos;
        }
        //Andrea Celeste
        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes()
            {
                DNI = txt_dniCliente.Text,
                Nombre = txt_nombreCliente.Text,
                Tel = txt_clienteTelefono.Text
            };

            string msg = VentaIsAllReady();

            if (msg == string.Empty)
            {
                Ventas venta = new Ventas()
                {
                    ID = _IDVenta,
                    DetallesVenta = _detallesVenta,
                    Cliente = c,
                    IDTipoVenta = 1,
                    IDColaborador = Menu.colaborador.DNI,
                    FechaFin = DateTime.Now,
                    TotalVenta = Total,
                    IDCliente     = c.DNI

                };

                bool ok = ventaController.SaveVenta(venta);

                if (ok)
                {
                    MessageBox.Show($"Venta Terminada\nMonto: {Total} \na continuacion se imprimira la factura", "Mensaje del sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MostrarFactura(venta);

                    CargarDataGrid();
                    ClearVenta();

                }
                else
                {
                    MessageBox.Show($"Venta no Terminada\nMonto: {Total}", "Mensaje del sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                
                
            }
            else
                MessageBox.Show("Faltan los siguientes datos:\n"+msg, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void ClearVenta()
        {
            Total = 0;
            l_monto.Text = string.Empty;
            _IDVenta = Guid.NewGuid();
            txt_dniCliente.Text = string.Empty;
            ClearCliente();

            _detallesVenta = new List<DetallesVentas>();
            ActualizarListView();
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell 3 = precio
            decimal precio = (decimal)GetCell(3);
            txt_precio.Value = precio;
        }

        

        private void btn_agregarProducto_Click(object sender, EventArgs e)

        {
            if (txt_cantidadProducto.Value == 0)
            {
                MessageBox.Show("Cantidad ausente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (GetCell(4) < txt_cantidadProducto.Value)
                {
                    MessageBox.Show("No hay suficientes existencia del producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    if (txt_cantidadProducto.Value != 0 && txt_precio.Value != 0)
                    {
                        var descuento = txt_precio.Value * (txt_descuento.Value / 100);
                        DetallesVentas dv = new DetallesVentas()
                        {
                            IDVenta = _IDVenta,
                            IDProducto = GetCell(0),
                            Cantidad = (int)txt_cantidadProducto.Value,
                            PrecioVenta = (float)(txt_precio.Value - (descuento) ),
                            Producto = GetCell(2),
                            descuento = (float)(descuento),
                            PrecioProducto = (float)txt_precio.Value

                        };

                        CargarListVew(dv);
                        ClearProducto();

                    }
                    else
                        MessageBox.Show(_msg, "Faltan datos de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
            }



        }
        private void CargarListVew(DetallesVentas dv)
        {
            Total += dv.SubTotal;
            l_monto.Text = string.Format("{0:C2}", Total);
            _detallesVenta.Add(dv);
            // actualizar el listview
            ActualizarListView();

        }
        private void ActualizarListView()
        {
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = _detallesVenta;
            lb_productosVenta.DisplayMember = "Info";
        }
        private dynamic GetCell(int cell = 0)
        {
            // ID, Codigo, Producto, Precio, Existencias
            // 0 ,      1,        2,      3,          4
            return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[cell].Value;
        }

        private void ClearProducto()
        {
            txt_cantidadProducto.Value = 1;
            txt_precio.Value = 0;
            txt_descuento.Value = 0;
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
                    txt_clienteTelefono.Text = cliente.Tel;
                }
            }
            if (txt_dniCliente.Text.Length == 0)
                ClearCliente();
        }

        private void HideShowLabels(bool visible)
        {
            labelClienteNuevo.Visible = visible;
            labelNombre.Visible = visible;
            labelTelefono.Visible = visible;
        }
        private void ClearCliente()
        {
            txt_nombreCliente.Clear();
            txt_clienteTelefono.Clear();
        }

      
        private string VentaIsAllReady()
        {
            string msg = txt_dniCliente.Text.Length == 13 ? string.Empty : "* DNI del Cliente\n";
            msg += txt_nombreCliente.Text != string.Empty ? "" : "* Nombre del Cliente\n";
            msg += txt_clienteTelefono.Text != string.Empty ? "" : "* Telefono del Cliente\n";
            msg += _detallesVenta.Count > 0 ? "" : "* Agregar Productos a la Venta\n";
          
            return msg;

        }
        //NO se

        private void VentaView_Load(object sender, EventArgs e)
        {

        }

        private void btn_quitarItem_Click(object sender, EventArgs e)
        {
            int i = lb_productosVenta.SelectedIndex;
            if (lb_productosVenta.Items.Count > 0)
            {
                Total -= _detallesVenta[i].SubTotal;
                _detallesVenta.RemoveAt(i);
                ActualizarListView();
                l_monto.Text = string.Format("{0:C2}", Total);
  
            }
            else
            {
                MessageBox.Show("No esta permitido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_buscarProducto_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_buscarProducto.Text.ToLower();

            List<Productos> filtrados = productos.Where<Productos>(x => {

                return x.Producto.ToLower().StartsWith(buscar) || x.Codigo.ToLower().StartsWith(buscar);


            }).ToList();

            dgv_productos.DataSource = null;
            dgv_productos.DataSource = filtrados;
        }

        private void txt_dniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void txt_clienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void MostrarFactura(Ventas venta)
        {
            var verfactura = new Factura(venta);

            this.Hide();

            Menu.main_panel.BackColor = Color.LightGray;
            this.BackColor = Color.LightGray;

            verfactura.ShowDialog();

            this.BackColor = Color.White;
            Menu.main_panel.BackColor = Color.White;

            this.Show();
        }
        
    }
}
