using SuMueble.DataAccess;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            var colaborador = new Colaborador();
            using (var db = new SuMuebleDBContext())
            {
                colaborador = db.Colaboradores.Find(user);
            }
            if (colaborador != null)
            {

                if (colaborador.Activo)
                {
                    if (colaborador.Clave == password)
                    {
                        Menu menu = new Menu(colaborador);
                        menu.Show();
                        this.Hide();

                    }
                  
                }
                else {
                    MessageBox.Show("Colaborador inhabilitado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else
                MessageBox.Show("Codigo o Clave de Usuario Invalido", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            txt_user.Text = "";
            txt_password.Text = "";
            txt_user.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_verContrasena.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else {
                txt_password.PasswordChar = '●';
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
