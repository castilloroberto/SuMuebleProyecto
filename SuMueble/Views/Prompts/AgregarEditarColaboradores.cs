using SuMueble.Controller;
using SuMueble.Models;
using SuMueble.Views.Prompts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SuMueble.Helpers;

namespace SuMueble.Views
{
    public partial class AgregarEditarColaboradores : Form
    {
        ColaboradorControlador cControlador = new ColaboradorControlador();
        PuestoControlador pControlador = new PuestoControlador();
        public AgregarEditarColaboradores(string DNI = null)
        {
            InitializeComponent();
            CargarPuestos();
            if (DNI != null)
            {
                CargarColaborador(DNI);
            }
        }

        private void CargarColaborador(string dni)
        {
            var colaborador = cControlador.Get(dni);
            txt_correo.Text = colaborador.Email;
            txt_dni.Text = colaborador.DNI;
            txt_nombre.Text = colaborador.Nombre;
            txt_rtn.Text = colaborador.RTN;
            txt_telefono.Text = colaborador.Telefono;
            txt_direccion.Text = colaborador.Direccion;
            dtp_fechaNacimiento.Value = colaborador.FechaNacimiento;
            dtp_contratoIniciado.Value = colaborador.FechaContratado;
            txt_clave.Text = colaborador.Clave;
            if (colaborador.FechaFinContrato == null)
            {
                txt_finContrato.Text = "No definido";

            } else
            {
                txt_finContrato.Text = colaborador.FechaFinContrato.Value.ToString();

            }

            cb_puesto.SelectedValue = colaborador.PuestoFk;
            txt_dni.Enabled = false;
        }

        private bool validardatos()
        {


            List<string> errores = new List<string>();
            
            var name = txt_nombre.Text.Trim();
            if (name == "" || !VentaView.validarNombre(name))
            {
                errores.Add("Nombre\n");
                txt_nombre.Text = txt_nombre.Text.Trim();
            }
            var dni = txt_dni.Text.Trim();
            if ( dni == "" || VentaView.ValidarDNI(dni) == false)
            {
                errores.Add("DNI\n");

            }
            var rtn = txt_rtn.Text.Trim();

            if (rtn.Length != 14)
            {
                
                    errores.Add("RTN\n");

            } else if (!VentaView.ValidarDNI(rtn.Remove(13)))
                    errores.Add("RTN\n");

            var tel = txt_telefono.Text.Trim();
            if (!VentaView.telValido(tel))
            {
                errores.Add("Telefono (Debe tener 8 numeros)\n");

            }
            if (txt_clave.Text.Trim().Length < 5) // puede ser 8 tambien
            {
                errores.Add("Clave (Minimo 5 caracteres)\n");

            }
            if (txt_correo.Text.Trim().Length < 10)
            {

                errores.Add("Correo\n");
            }
            if (txt_direccion.Text.Trim().Length < 15)
            {
                errores.Add("Direccion (Minimo 15 caracteres)\n");
                txt_direccion.Text = txt_direccion.Text.Trim();
            }
            // -1 = anterior a la selcccionada
            // 0 = fechas son iguales
            // 1 = fecha es mayor a la seleccionada
            var minYear = DateTime.Now.Year - 16;
            var minFecha = new DateTime(minYear,12,31);// 01/01/2003
            int res = dtp_fechaNacimiento.Value.CompareTo(minFecha); // 2021 = 2003
            if (res == 1)
            {
                errores.Add("Fecha invalida (Debe tener 16 años minimo)\n");
            }

            if (errores.Count > 0)
            {

                var msg = "Los siguientes campos son invalidos:\n";

                errores.ForEach(e =>
                {
                    msg += e;
                });

                MessageBox.Show(msg, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

                return false;
            }
            return true;



        }


        private bool email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void btn_hecho_Click(object sender, EventArgs e)
        {
            
            if (validardatos())
            { 
                if (email_bien_escrito(txt_correo.Text))
                {

                    // enviar el insert 
                    Colaborador colaborador = new Colaborador()
                    {
                        Clave = Security.Encrypt(txt_clave.Text),
                        FechaContratado = dtp_contratoIniciado.Value,
                        Direccion = txt_direccion.Text,
                        DNI = txt_dni.Text,
                        Email = txt_correo.Text,
                        FechaNacimiento = dtp_fechaNacimiento.Value,
                        Nombre = txt_nombre.Text,
                        RTN = txt_rtn.Text,
                        Telefono = txt_telefono.Text,
                        PuestoFk = cb_puesto.SelectedValue.GetHashCode(),
                    };
                    cControlador.Save(colaborador);
                    MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show("Formato de correo invalido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_contratoIniciado_ValueChanged(object sender, EventArgs e)
        {

        }
        private void CargarPuestos()
        {
            var puestos = pControlador.GetPuestos();
            
            if (Menu.colaborador.PuestoFk != 1)
            {
                puestos = puestos.Where( item => {
                    return item.IdPuesto != 1;
                }).ToList();
            }

            cb_puesto.DataSource = puestos;
            cb_puesto.DisplayMember = "Puesto";
            cb_puesto.ValueMember = "IdPuesto";
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void ch_verContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_verContrasena.Checked)
            {
                txt_clave.PasswordChar = '\0';
            }
            else
            {
                txt_clave.PasswordChar = '*';
            }
        }

      
    }
}
