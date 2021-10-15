using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SuMueble.Models;
using SuMueble.Views.Prompts;
using SuMueble.DataAccess;

namespace SuMueble.Views
{
    public partial class VentaView : UserControl
    {
        
        List<Producto> productos;

        //variables
        private decimal Total = 0;
        private List<DetalleVenta> _detallesVenta = new List<DetalleVenta>();
        private string _msg = "1. Seleccione un producto\n2. Indique la cantidad que se venderá\n3. Asegurese de No borrar el precio del producto de el cuadro de texto en la parte inferior";

        // metodos
        public VentaView()
        {
            InitializeComponent();
            LoadData();
            CargarDataGrid();
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void LoadData()
        {
            using (var db = new SuMuebleDBContext())
            {
                productos = db.Productos.Include("Categoria").ToList();
                
            }

        }
        private void CargarDataGrid()
        {
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = productos;
        }
        //Andrea Celeste
        public static bool validarNombre(string nombre_)
        {
            //  "        aaaaaaaaaaaaaaa          "
            var nombre = nombre_.Trim();
            if (nombre.Length == 0) return false;
            
            char primerLetra = nombre.ElementAt(0); //nombre.Remove(1);
            int count = 0;
            foreach (var letra in nombre)
            {
                if (letra == primerLetra)
                {
                    count++;
                }
            }
            if (count == nombre.Length)
            {
                return false;
            }


            return true;
        } 
        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            if (txt_clienteTelefono.Text.FirstOrDefault() == '0')
            {
                MessageBox.Show("El primer número del teléfono no puede ser cero");
                txt_clienteTelefono.Text = "";

            }
            else if (txt_nombreCliente.Text.FirstOrDefault() == ' ') 
            {
                MessageBox.Show("El primer caracter del nombre no puede ser un espacio");
                txt_nombreCliente.Text = "";

            }
            else
            {


                Cliente c = new Cliente()
                {
                    DNI = txt_dniCliente.Text.Trim(),
                    Nombre = txt_nombreCliente.Text.Trim(),
                    Telefono = txt_clienteTelefono.Text.Trim()
                };


                string msg = VentaIsAllReady();
                if (msg == string.Empty)
                {
                    _detallesVenta = _detallesVenta.ConvertAll(x =>
                    {
                        x.Producto = null;
                        return x;
                    });
                    Venta venta = new Venta()
                    {
                        DetallesVenta = _detallesVenta,
                        TipoVentaId = 1,
                        ClienteDNI = c.DNI,
                        ColaboradorDNI = Menu.colaborador.DNI,

                    };
                    try
                    {
                        using (var db = new SuMuebleDBContext())
                        {
                            var cExist = db.Clientes.Find(c.DNI);
                            if (cExist == null)
                            {
                                venta.Cliente = c; 

                            }
                            else
                            {
                                cExist.Nombre = c.Nombre;
                                cExist.Telefono = c.Telefono;

                            }
                            db.Ventas.Add(venta);
                            db.SaveChanges();
                        }
                        MessageBox.Show($"Venta Terminada\nMonto: {Total} \na continuacion se imprimira la factura", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MostrarFactura(venta);
                        DecrementaInventario();
                        ClearVenta();
                    }
                    catch (Exception err)
                    {

                        MessageBox.Show($"No se pudo terminar la venta\nError:{err}", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



                }
                else
                    MessageBox.Show("los siguientes campos son invalidos:\n" + msg, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        void DecrementaInventario()
        {
            using (var db = new SuMuebleDBContext())
            {
                

                _detallesVenta.ForEach(dv =>
                {
                    var prod = db.Productos.Find(dv.ProductoId);
                    prod.Cantidad -= dv.Cantidad;
                    db.SaveChanges(); 
                });
            }
            
        }
        private void ClearVenta()
        {
            Total = 0;
            l_monto.Text = string.Empty;
            txt_dniCliente.Text = string.Empty;
            ClearCliente();

            _detallesVenta = new List<DetalleVenta>();
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
                        var prodSelected = GetCell(0);
                        DetalleVenta dv = new DetalleVenta()
                        {
                            
                            ProductoId = prodSelected,
                            Cantidad = (int)txt_cantidadProducto.Value,
                            PrecioVenta = txt_precio.Value - (descuento) ,
                            Producto = productos.Find( x => x.Id == prodSelected),
                            Descuento = descuento,

                        };

                        CargarListVew(dv);
                        ClearProducto();

                    }
                    else
                        MessageBox.Show(_msg, "Faltan datos de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
            }



        }
        private void CargarListVew(DetalleVenta dv)
        {
            Total += dv.SubTotal;
            l_monto.Text = string.Format("{0:C2}", Total);
            _detallesVenta.Add(dv);
            // actualizar el listview
            var idx = productos.IndexOf(dv.Producto);
            dv.Producto.Cantidad -= dv.Cantidad;
            productos[idx] = dv.Producto;
            CargarDataGrid();
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
                Cliente cliente = new Cliente();//clienteControlador.GetCliente(txt_dniCliente.Text)
                using (var db = new SuMuebleDBContext())
                {
                    cliente = db.Clientes.Find(txt_dniCliente.Text.Trim());
                }
                if (cliente == null)
                {
                    HideShowLabels(true);
                }
                else
                {
                    HideShowLabels(false);
                    txt_nombreCliente.Text = cliente.Nombre;
                    txt_clienteTelefono.Text = cliente.Telefono;
                }
            }
            //if (txt_dniCliente.Text.Length == 0)
            //    ClearCliente();
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

       
 
        //VALIDAR DNI
        public static bool ValidarDNI(string dni)
        {

            bool error = false;
            long trash = 0;
            if (!(long.TryParse(dni, out trash)))
            {
                //return "No es un numero";
                return error;

            }

            if (dni.Length != 13)
            {
                //return "no tiene 13 caracteres";
                return error;
            }
            //0703-2001-01235
            string depto = dni.Remove(2);

            int municipio = int.Parse(dni.Remove(4).Substring(2));

            int year = int.Parse(dni.Substring(4).Remove(4));

            string codigoUnico = dni.Substring(8);

            //convertir
            int deptoInt = int.Parse(depto);

            //70-03
            if (deptoInt <= 0 || deptoInt > 18)
            {
                //return "Departamento no es valido";
                return error;

            }

            if (municipio <= 0 || municipio > 28)
            {
                //return "Municipio no es valido";
                return error;
            }

            if (year < 1821 || year >= DateTime.Now.Year - 18) // 2003 --hola futuros nosostros 
            {
                //return $"año no es valido: {year}";
                return error;
            }

            return true;
        }

        static bool MultipleStartWith(string target,List<char> chars)
        {
            bool res = false; 
            chars.ForEach(e => 
            {
                if (target.StartsWith(e))
                {
                    res = true;
                }
            });

            return res;
        }

        public static bool telValido(string tel)
        {
            if (MultipleStartWith(tel, new List<char>() {  '8', '3','2','9' }))
            {
                // 8888 - 8888
                if (tel.Length < 8)
                    {
                        return false;
                    }
                    var mitad = tel.Substring(4);
                    var mitad2 = tel.Remove(4);
                    if (mitad == mitad2)
                    {
                        return false;
                    }
                    return true;

            }
            return false;
        } 

        private string VentaIsAllReady()
        {
            bool ok = ValidarDNI(txt_dniCliente.Text.Trim());
            //validaciones 
          

            string msg = txt_dniCliente.Text.Trim().Length == 13 ? "" : "* DNI del Cliente\n";
            msg += (txt_nombreCliente.Text != "") ? "" : "* Nombre del Cliente\n";
            msg += txt_clienteTelefono.Text != "" ? "" : "* Telefono del Cliente\n";
            msg += _detallesVenta.Count > 0 ? "" : "* Agregar Productos a la Venta\n";
            msg += telValido(txt_clienteTelefono.Text.Trim()) == true ? "" : "*El telefono no es valido\n";
            msg += (validarNombre(txt_nombreCliente.Text) == true) ? "" : "*El Nombre no es valido\n";
            //msg += txt_dniCliente.Text
            msg += ok == false ? "*DNI invalido" : "";
           
          
            return msg;

        }
       
        
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

            List<Producto> filtrados = productos.Where<Producto>(x => {

                try
                {
                    return x.Nombre.ToLower().StartsWith(buscar) || x.Id.ToString().StartsWith(buscar);
                }
                catch
                {
                    return false;
                }


            }).ToList();

            dgv_productos.DataSource = null;
            dgv_productos.DataSource = filtrados;
        }

        private void txt_dniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //valide numeros , que no permita, espacios, 
            
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

        private void txt_clienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

        }

        private void MostrarFactura(Venta venta)
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

        private void txt_dniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_clienteTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_descuento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46 || e.KeyChar == 44) )
            {
                MessageBox.Show("Introduzca solo números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txt_clienteTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
