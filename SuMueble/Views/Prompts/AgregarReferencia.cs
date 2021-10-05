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
            else if (txtDNIReferencia.Text.Length != 13) //date:02/10/2021
            {   // longitud 13
                MessageBox.Show("DNI Incompleto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNIReferencia.Focus();
            }
            else if (txt_nombreCliente.Text == "")
            {
                MessageBox.Show("Nombre referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Focus();
            }
            else if (txt_nombreCliente.Text.Length < 12) //date:02/10/2021
            {   // min 12 - max 150
                MessageBox.Show("Nombre Incompleto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Focus();
            }
            else if (txt_telefono.Text == "")
            {
                MessageBox.Show("Teléfono referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
            }
            else if (txt_telefono.Text.Length != 8) //date:02/10/2021
            {   // longitud 8 
                MessageBox.Show("Número Teléfononico Incompleto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Dirección referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
            }
            else if (txtDireccion.Text.Length < 9) //date:02/10/2021
            {   // dir corta min 9 - max 200
                MessageBox.Show("Dirección corta Incompleta", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
            }
            else if (txtCodigoFactura.Text == "")
            {
                MessageBox.Show("Código Recibo referencia esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoFactura.Focus();
            }
            else if (txtCodigoFactura.Text.Length < 7) //date:02/10/2021
            {   // min 7 - max 18 
                MessageBox.Show("Código Recibo Incompleto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoFactura.Focus();
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
