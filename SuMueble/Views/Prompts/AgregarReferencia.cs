using SuMueble.Models;
using System;
using System.Windows.Forms;

namespace SuMueble.Views.Prompts
{
    public partial class AgregarReferencia : Form
    {
        public AgregarReferencia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES TEXTBOX VACIOS
            if (txtDNIReferencia.Text == "")
            {
                MessageBox.Show("DNI referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNIReferencia.Focus();
            }
            else if (txt_nombreCliente.Text == "")
            {
                MessageBox.Show("Nombre referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Focus();
            }
            else if (txt_telefono.Text == "")
            {
                MessageBox.Show("Telefono referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
            }
            else if (txtCodigoFactura.Text == "")
            {
                MessageBox.Show("Codigo Factura referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoFactura.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Codigo Factura referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
            }
            else
            {
                Referencias referencias = new Referencias()
                {
                    CodigoRecibo = txtCodigoFactura.Text,
                    Direccion = txtDireccion.Text,
                    DNIReferencia = txtDNIReferencia.Text,
                    Nombre = txt_nombreCliente.Text,
                    Tel = txt_telefono.Text,
                    IDVenta = VentaCreditoView._IDVenta,
                };
                VentaCreditoView.listaReferencias.Add(referencias);
                MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void txtDNIReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        //validaciones espacios al inicio y final //date:01/10
        private void txt_nombreCliente_Leave(object sender, EventArgs e)
        {
            txt_nombreCliente.Text = txt_nombreCliente.Text.Trim(); 
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            txtDireccion.Text = txtDireccion.Text.Trim();
        }
    }
}
