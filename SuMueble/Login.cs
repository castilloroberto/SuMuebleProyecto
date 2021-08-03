using SuMueble.Controller;
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
        ColaboradorControlador colaboradorControlador = new ColaboradorControlador();
        Colaboradores colaborador;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            colaborador = colaboradorControlador.GetColaborador(user);
            
            if (colaborador != null)
            {
                if (colaborador.Clave == password)
                {
                    Menu menu = new Menu(colaborador);
                    menu.Show();
                    this.Hide();

                }
                txt_password.Text = "";
            }
            else
                MessageBox.Show("Codigo o Clave de Usuario Invalido", "Contrasena Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            txt_user.Text = "";   
            txt_user.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_verContrasena.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else {
                txt_password.PasswordChar = '*';
            }
        }
    }
}
